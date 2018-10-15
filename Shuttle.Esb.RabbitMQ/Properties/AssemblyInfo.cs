using System.Reflection;
using System.Runtime.InteropServices;

#if NET461
[assembly: AssemblyTitle(".NET Framework 4.6.1")]
#endif

#if NET462
[assembly: AssemblyTitle(".NET Framework 4.6.2")]
#endif

#if NET47
[assembly: AssemblyTitle(".NET Framework 4.7")]
#endif

#if NET471
[assembly: AssemblyTitle(".NET Framework 4.7.1")]
#endif

#if NETCOREAPP2_0
[assembly: AssemblyTitle(".NET Core 2.0")]
#endif

#if NETCOREAPP2_1
[assembly: AssemblyTitle(".NET Core 2.1")]
#endif

#if NETSTANDARD2_0
[assembly: AssemblyTitle(".NET Standard 2.0")]
#endif

[assembly: AssemblyVersion("10.0.13.0")]
[assembly: AssemblyCopyright("Copyright © Eben Roux 2018")]
[assembly: AssemblyProduct("Shuttle.Esb.RabbitMQ")]
[assembly: AssemblyCompany("Shuttle")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyInformationalVersion("10.0.13")]
[assembly: ComVisible(false)]
