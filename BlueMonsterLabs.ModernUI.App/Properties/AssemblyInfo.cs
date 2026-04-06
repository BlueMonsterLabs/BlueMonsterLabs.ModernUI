using System.Reflection;
using System.Windows;
using System.Windows.Media;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ModernUI Demo App")]
[assembly: AssemblyDescription("Demonstrating the features of Modern UI for WPF")]
[assembly: AssemblyConfiguration("retail")]
[assembly: AssemblyCompany("Blue Monster Labs")]
[assembly: AssemblyProduct("ModernUI demo")]
[assembly: AssemblyCopyright("Copyright © Blue Monster Labs 2026")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]

// required for PerMonitor DPI support to work
[assembly:DisableDpiAwareness]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.2153")]
[assembly: AssemblyFileVersion("1.0.0.0")]
