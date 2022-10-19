using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(MassTooglePrioritize.BuildInfo.Description)]
[assembly: AssemblyDescription(MassTooglePrioritize.BuildInfo.Description)]
[assembly: AssemblyCompany(MassTooglePrioritize.BuildInfo.Company)]
[assembly: AssemblyProduct(MassTooglePrioritize.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + MassTooglePrioritize.BuildInfo.Author)]
[assembly: AssemblyTrademark(MassTooglePrioritize.BuildInfo.Company)]
[assembly: AssemblyVersion(MassTooglePrioritize.BuildInfo.Version)]
[assembly: AssemblyFileVersion(MassTooglePrioritize.BuildInfo.Version)]
[assembly: MelonInfo(typeof(MassTooglePrioritize.MassTooglePrioritize), MassTooglePrioritize.BuildInfo.Name, MassTooglePrioritize.BuildInfo.Version, MassTooglePrioritize.BuildInfo.Author, MassTooglePrioritize.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]