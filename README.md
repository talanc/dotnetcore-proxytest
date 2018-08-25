Demonstrates a bug introduced in .NET Core 2.1 where HTTPS requests will not work under a corporate proxy. May also include tests for future versions of .NET Core in preview.

Run `create-test-output.bat`, or use the Visual Studio Test Explorer `Run All`.

## Organisation
- ProxyLib: .NET Standard 2.0 library.
- ProxyTest-2.0: .NET Core 2.0 test project.
- ProxyTest-2.1: .NET Core 2.1 test project.
- ProxyTest-2.2: .NET Core 2.2 test project.

### Unit Tests
All test projects have two unit tests each; one for a HTTP GET and the other for a HTTPS GET.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.0-https: Passes.
- dotnetcore-2.0-http: Passes.
- dotnetcore-2.1-https: **Fails**.
- dotnetcore-2.2-http: Passes.
- dotnetcore-2.2-https **Fails**.

See `*.txt` for more information.
