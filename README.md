# tests-csharp
tests Examples in C# .net core

dotnet test src/test-example.sln 

dotnet test src/tests/tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=../lcov 



Starting test execution, please wait...
                                                                                                                      
Test Run Successful.
Total tests: 1
     Passed: 1
 Total time: 1.3768 Seconds

Calculating coverage result...
  Generating report '../lcov.opencover.xml'
  Generating report '../lcov.info'

+-------------+------+--------+--------+
| Module      | Line | Branch | Method |
+-------------+------+--------+--------+
| application | 100% | 100%   | 100%   |
+-------------+------+--------+--------+

+---------+------+--------+--------+
|         | Line | Branch | Method |
+---------+------+--------+--------+
| Total   | 100% | 100%   | 100%   |
+---------+------+--------+--------+
| Average | 100% | 100%   | 100%   |
+---------+------+--------+--------+