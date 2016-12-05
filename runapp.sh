#!/bin/bash
# Restore and run the app
dotnet restore
dotnet run --server.urls http://0.0.0.0:80