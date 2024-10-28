# htsfa-airlines-dotnet

## Development Instructions

```bash
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i https://airlines-api.hopper.com/airline/v1.1/docs/docs.yaml \
    -g csharp \
    -o /local/htsfa-airlines-dotnet/

./airline-api/target/scala-2.13/resource_managed/main/docs/airline/v1.1/openapi.yml
