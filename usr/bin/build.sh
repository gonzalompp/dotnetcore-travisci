#!/usr/bin/env bash
cd src/Calculator/
dotnet restore && dotnet build
cd ../Calculator.Tests/
dotnet restore && dotnet build
