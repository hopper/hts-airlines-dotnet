# htsfa-airlines-dotnet contribution guidelines

## Development

You can regenerate the client using `regenerate.sh`.

The Spreedly sub-client can be regenerated separately using `regenerate-spreedly.sh`.

### Customising generated code

Some generated files are intentionally different from the raw generator output. Rather than patching files after generation, we use a custom template directory (`templates/`) that is passed to the generator via `--template-dir`. The generator picks up any `.mustache` file in that directory and uses it in place of the built-in template.

Currently overridden templates (both under `templates/libraries/generichost/`):

- **`TokenProvider`1.mustache`** — `GetAsync` is declared `protected abstract` instead of `internal abstract`, so that consumers of the NuGet package can subclass `TokenProvider<T>` from outside the assembly.
- **`RateLimitProvider`1.mustache`** — `GetAsync` override is `protected override` to match.

If you upgrade the generator version in either shell script, re-extract the base templates and re-apply the modifications:

```bash
# Extract fresh templates for the new generator version
mkdir -p templates-extract
docker run --rm -v "${PWD}/templates-extract:/out" openapitools/openapi-generator-cli:<NEW_VERSION> \
    author template -g csharp --library generichost -o /out

# Copy only the two we override, then delete the extraction folder
cp "templates-extract/libraries/generichost/TokenProvider\`1.mustache" "templates/libraries/generichost/"
cp "templates-extract/libraries/generichost/RateLimitProvider\`1.mustache" "templates/libraries/generichost/"
rm -rf templates-extract

# Re-apply the modifications
# In TokenProvider`1.mustache:  internal abstract  →  protected abstract
# In RateLimitProvider`1.mustache:  internal override  →  protected override
```

## Publishing

Update `VERSION` at the top of `regenerate.sh` to the next version number, then run the script. The generator will stamp the new version into `src/Com.Hopper.Hts.Airlines/Com.Hopper.Hts.Airlines.csproj` automatically.

Create the package

```bash
dotnet pack src/Com.Hopper.Hts.Airlines
```

Example run:

```bash
➜  htsfa-airlines-dotnet git:(main) dotnet pack src/Com.Hopper.Hts.Airlines
  Determining projects to restore...
  Restored /Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Com.Hopper.Hts.Airlines.csproj (in 506 ms).
/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Client/ApiClient.cs(457,17): warning CS0618: 'RestClientOptions.MaxTimeout' is obsolete: 'Use Timeout instead.' [/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/Com.Hopper.Hts.Airlines.csproj]
  Com.Hopper.Hts.Airlines -> /Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/bin/Release/net8.0/Com.Hopper.Hts.Airlines.dll
  The package Com.Hopper.Hts.Airlines.0.1.2 is missing a readme. Go to https://aka.ms/nuget/authoring-best-practices/readme to learn why package readmes are important.
  Successfully created package '/Users/llaw/Documents/Github/htsfa-airlines-dotnet/src/Com.Hopper.Hts.Airlines/bin/Release/Com.Hopper.Hts.Airlines.0.1.2.nupkg'.
```

Go to [NuGet](https://www.nuget.org/packages/manage/upload) and upload the package artifact created.
In the example above, it is `Com.Hopper.Hts.Airlines.0.1.2.nupkg`.
After submission, the package will be ready for consumption usually within 10-15 minutes.

You will need to obtain an Azure account to access NuGet. Contact IT to do so.
