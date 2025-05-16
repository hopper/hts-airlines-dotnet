# htsfa-airlines-dotnet contribution guidelines

## Development

You can regenerate the client using `regenerate.sh`.

## Publishing

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
