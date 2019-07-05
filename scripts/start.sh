#!/bin/bash
export ASPNETCORE_ENVIRONMENT=local
cd src/Pacco.Web
dotnet run --urls http://*:5050
