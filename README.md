# tests-csharp
tests Examples in C# .net core

dotnet test src/test-example.sln 

dotnet test src/tests/tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=../lcov 
