using System;
using System.Reflection;
using System.Resources;
using System.Windows;
using System.Windows.Markup;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ModernUI")]
[assembly: AssemblyConfiguration("retail")]
[assembly: AssemblyCompany("Blue Monster Labs")]
[assembly: AssemblyProduct("ModernUI")]
[assembly: AssemblyCopyright("Copyright ©Blue Monster Labs 2026")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: CLSCompliant(true)]

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
//
// This setting being managed by GitVersion.MSBuild
//


[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page, 
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page, 
                                              // app, or any theme specific resource dictionaries)
)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

[assembly: XmlnsPrefix("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "mui")]
[assembly: XmlnsDefinition("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "BlueMonsterLabs.ModernUI")]
[assembly: XmlnsDefinition("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "BlueMonsterLabs.ModernUI.Presentation")]
[assembly: XmlnsDefinition("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "BlueMonsterLabs.ModernUI.Windows")]
[assembly: XmlnsDefinition("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "BlueMonsterLabs.ModernUI.Windows.Controls")]
[assembly: XmlnsDefinition("https://github.com/BlueMonsterLabs/BlueMonsterLabs.ModernUI", "BlueMonsterLabs.ModernUI.Windows.Navigation")]
