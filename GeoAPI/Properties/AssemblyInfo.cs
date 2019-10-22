using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("GeoAPI")]
[assembly: AssemblyDescription(".Net Standard version of GeoAPI for DotSpatial")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Stable")]
#endif
[assembly: AssemblyCompany("GeoDigital, Inc., forked from NetTopologySuite Team")]
[assembly: AssemblyProduct("GeoAPI")]
[assembly: AssemblyCopyright("Copyright ©  2007-2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
#if !PCL
[assembly: ComVisible(false)]
[assembly: Guid("b6726fc4-0319-4a6d-84f5-aafc6ba530e3")]
#endif