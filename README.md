Demonstrates a bug introduced in .NET Core 2.1 where HTTPS requests will not work under a proxy.

Run `dotnet test ProxyTest-2.0` and `dotnet test ProxyTest-2.1`, or use the Visual Studio Test Explorer `Run All`.

## Organisation
- ProxyLib: A .NET Standard 2.0 library.
- ProxyTest-2.0: A .NET Core 2.0 test project.
- ProxyTest-2.1: A .NET Core 2.1 test project.

### Unit Tests
Both test projects have two unit tests each; one to test a HTTP GET request and the other to test a HTTPS GET request.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.0-https: Passes.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.1-https: **Fails**.

## Test output
_See **dotnet-test-proxytest-2.0.txt** and **dotnet-test-proxytest-2.1.txt** for more details._

`dotnet test ProxyTest-2.0`
```
Passed   NetCore20_Http
Passed   NetCore20_Https
```

`dotnet test ProxyTest-2.1`
```
Passed   NetCore21_Http
Failed   NetCore21_Https
Error Message:
 Test method ProxyTest21.NetCore21_Tests.NetCore21_Https threw exception: 
System.Net.Http.HttpRequestException: Response status code does not indicate success: 407 (Proxy Authentication Required ( The ISA Server requires authorization to fulfill the request. Access to the Web Proxy filter is denied.  )).
Stack Trace:
    at System.Net.Http.HttpResponseMessage.EnsureSuccessStatusCode()
   at ProxyTest.Class1.Api(String url) in C:\Users\talan\Desktop\ProxyTest\ProxyLib\Class1.cs:line 18
   at ProxyTest.Class1.Https() in C:\Users\talan\Desktop\ProxyTest\ProxyLib\Class1.cs:line 28
   at ProxyTest21.NetCore21_Tests.NetCore21_Https() in C:\Users\talan\Desktop\ProxyTest\ProxyTest-2.1\NetCore21_Tests.cs:line 19
```
