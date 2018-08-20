Demonstrates a bug introduced in .NET Core 2.1 where HTTPS requests will not work under a proxy. Also tests 2.2 preview which brings up a different thrown exception.

Run `create-test-output.bat`, or use the Visual Studio Test Explorer `Run All`.

Latest version tested against: **.NET Core 2.1.1**

## Organisation
- ProxyLib: A .NET Standard 2.0 library.
- ProxyTest-2.0: A .NET Core 2.0 test project.
- ProxyTest-2.1: A .NET Core 2.1 test project.
- ProxyTest-3.0-preview1: A .NET Core 3.0 (3.0.0-preview1-26814-05) test project.

### Unit Tests
Both test projects have two unit tests each; one to test a HTTP GET request and the other to test a HTTPS GET request.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.0-https: Passes.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.1-https: **Fails**.
- dotnetcore-3.0.0-preview1-26814-05-http: Passes.
- dotnetcore-3.0.0-preview1-26814-05-https **Fails**.

## Test output
_See **dotnet-info.txt** for more information._
`dotnet --version`
```
3.0.100-alpha1-20180720-2
```

_See **dotnet-test-&ast;** for more information._

`dotnet test ProxyTest-2.0`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-2.0\bin\Debug\netcoreapp2.0\ProxyTest-2.0.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 6.3935 Seconds
```

`dotnet test ProxyTest-2.1`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-2.1\bin\Debug\netcoreapp2.1\ProxyTest-2.1.dll(.NETCoreApp,Version=v2.1)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Failed   NetCore21_Https
Error Message:
 Test method ProxyTest21.NetCore21_Tests.NetCore21_Https threw exception: 
System.Net.Http.HttpRequestException: Response status code does not indicate success: 407 (Proxy Authentication Required ( The ISA Server requires authorization to fulfill the request. Access to the Web Proxy filter is denied.  )).
Stack Trace:
    at System.Net.Http.HttpResponseMessage.EnsureSuccessStatusCode()
   at ProxyTest.Class1.Api(String url) in C:\src\dotnetcore-proxytest\ProxyLib\Class1.cs:line 18
   at ProxyTest.Class1.Https() in C:\src\dotnetcore-proxytest\ProxyLib\Class1.cs:line 28
   at ProxyTest21.NetCore21_Tests.NetCore21_Https() in C:\src\dotnetcore-proxytest\ProxyTest-2.1\NetCore21_Tests.cs:line 19


Total tests: 2. Passed: 1. Failed: 1. Skipped: 0.
Test execution time: 1.2018 Seconds
```

`dotnet test ProxyTest-3.0-preview1`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-3.0-preview1\bin\Debug\netcoreapp3.0\ProxyTest-3.0-preview1.dll(.NETCoreApp,Version=v3.0)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.9791 Seconds
```
