Demonstrates a bug introduced in .NET Core 2.1 where HTTPS requests will not work under a proxy. Also tests 2.2 preview which brings up a different thrown exception.

Run `create-test-output.bat`, or use the Visual Studio Test Explorer `Run All`.

Latest version tested against: **.NET Core 2.1.1**

## Organisation
- ProxyLib: A .NET Standard 2.0 library.
- ProxyTest-2.0: A .NET Core 2.0 test project.
- ProxyTest-2.1: A .NET Core 2.1 test project.
- ProxyTest-2.2-Preview1-26620-03: A .NET Core 2.2 (preview1-26620-03) test project.

### Unit Tests
Both test projects have two unit tests each; one to test a HTTP GET request and the other to test a HTTPS GET request.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.0-https: Passes.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.1-https: **Fails**.
- dotnetcore-2.2-preview1-26620-03-http: Passes.
- dotnetcore-2.2-preview1-26620-03-https: **Fails**.

## Test output
_See **dotnet-info.txt** for more information._
`dotnet --version`
```
2.1.301
```

_See **dotnet-test-&ast;** for more information._

`dotnet test ProxyTest-2.0`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-2.0\bin\Debug\netcoreapp2.0\ProxyTest-2.0.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0-preview-20180510-03
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

Total tests: 2. Passed: 2. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 2.9659 Seconds
```

`dotnet test ProxyTest-2.1`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-2.1\bin\Debug\netcoreapp2.1\ProxyTest-2.1.dll(.NETCoreApp,Version=v2.1)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0-preview-20180510-03
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
Test execution time: 1.5291 Seconds
```

`dotnet test ProxyTest-2.2-preview1-26620-03`
```
Build started, please wait...
Build completed.

Test run for C:\src\dotnetcore-proxytest\ProxyTest-2.2-preview1-26620-03\bin\Debug\netcoreapp2.2\ProxyTest-2.2-Preview1-26620-03.dll(.NETCoreApp,Version=v2.2)
Microsoft (R) Test Execution Command Line Tool Version 15.8.0-preview-20180510-03
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Failed   NetCore22_Https
Error Message:
 Test method ProxyTest22_Preview1_26620_03.NetCore22_Preview1_26620_03_Tests.NetCore22_Https threw exception: 
System.Net.Http.HttpRequestException: Authentication failed because the connection could not be reused.
Stack Trace:
    at System.Net.Http.HttpConnection.DrainResponseAsync(HttpResponseMessage response)
   at System.Net.Http.AuthenticationHelper.SendWithNtAuthAsync(HttpRequestMessage request, Uri authUri, ICredentials credentials, Boolean isProxyAuth, HttpConnection connection, CancellationToken cancellationToken)
   at System.Net.Http.HttpConnectionPool.SendWithRetryAsync(HttpRequestMessage request, Boolean doRequestAuth, CancellationToken cancellationToken)
   at System.Net.Http.AuthenticationHelper.SendWithAuthAsync(HttpRequestMessage request, Uri authUri, ICredentials credentials, Boolean preAuthenticate, Boolean isProxyAuth, Boolean doRequestAuth, HttpConnectionPool pool, CancellationToken cancellationToken)
   at System.Net.Http.HttpConnectionPool.EstablishProxyTunnel(CancellationToken cancellationToken)
   at System.Threading.Tasks.ValueTask`1.get_Result()
   at System.Net.Http.HttpConnectionPool.CreateConnectionAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at System.Threading.Tasks.ValueTask`1.get_Result()
   at System.Net.Http.HttpConnectionPool.WaitForCreatedConnectionAsync(ValueTask`1 creationTask)
   at System.Threading.Tasks.ValueTask`1.get_Result()
   at System.Net.Http.HttpConnectionPool.SendWithRetryAsync(HttpRequestMessage request, Boolean doRequestAuth, CancellationToken cancellationToken)
   at System.Net.Http.RedirectHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at System.Net.Http.HttpClient.FinishSendAsyncBuffered(Task`1 sendTask, HttpRequestMessage request, CancellationTokenSource cts, Boolean disposeCts)
   at ProxyTest.Class1.Api(String url) in C:\src\dotnetcore-proxytest\ProxyLib\Class1.cs:line 17
   at ProxyTest.Class1.Https() in C:\src\dotnetcore-proxytest\ProxyLib\Class1.cs:line 28
   at ProxyTest22_Preview1_26620_03.NetCore22_Preview1_26620_03_Tests.NetCore22_Https() in C:\src\dotnetcore-proxytest\ProxyTest-2.2-preview1-26620-03\NetCore22_Preview1_26620_03_Tests.cs:line 19


Total tests: 2. Passed: 1. Failed: 1. Skipped: 0.
Test execution time: 1.5154 Seconds
```
