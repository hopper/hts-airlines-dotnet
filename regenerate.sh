#!/bin/bash

VERSION=0.1.13 docker run --rm -v "${PWD}/:/local" -v "${PWD}/api/:/api" openapitools/openapi-generator-cli:v7.10.0 generate \
    -i https://airlines-api.hopper.com/airline/v1.1/docs/docs.yaml \
    -g csharp \
    -o /local \
    --package-name Com.Hopper.Hts.Airlines \
    --additional-properties=nullableReferenceTypes=true,validatable=false,licenseId=MIT,packageVersion=$VERSION,library=generichost,targetFramework=net6.0\;net8.0 \
    --skip-validate-spec

