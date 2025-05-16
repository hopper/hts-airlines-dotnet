#!/bin/bash

VERSION=0.1.11 docker run --rm -v "${PWD}/spreedly/:/local" -v "${PWD}/api/:/api" openapitools/openapi-generator-cli:v7.10.0 generate \
    -i /api/spreedly.yaml \
    -g csharp \
    -o /local \
    --package-name Com.Hopper.Hts.Airlines.Spreedly \
    --additional-properties=nullableReferenceTypes=true,validatable=false,licenseId=MIT,packageVersion=$VERSION,library=generichost,targetFramework=net6.0\;net8.0 \
    --skip-validate-spec

cp "${PWD}/spreedly/src/Com.Hopper.Hts.Airlines.Spreedly/Api/"* "src/Com.Hopper.Hts.Airlines/Spreedly/Api/"
cp "${PWD}/spreedly/src/Com.Hopper.Hts.Airlines.Spreedly/Client/"* "src/Com.Hopper.Hts.Airlines/Spreedly/Client/"
cp "${PWD}/spreedly/src/Com.Hopper.Hts.Airlines.Spreedly/Extensions/"* "src/Com.Hopper.Hts.Airlines/Spreedly/Extensions/"
cp "${PWD}/spreedly/src/Com.Hopper.Hts.Airlines.Spreedly/Model/"* "src/Com.Hopper.Hts.Airlines/Spreedly/Model/"
