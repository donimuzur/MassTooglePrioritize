using MelonLoader;
using UnityEngine;

namespace MassTooglePrioritize
{
	public static class BuildInfo
	{
		public const string Name = "MassTooglePrioritize";
		public const string Description = "mass toogle prioritize with the same type Build site ";
		public const string Author = "donimuzur"; // Author of the Mod.  (MUST BE SET)
		public const string Company = null; // Company that made the Mod.  (Set as null if none)
		public const string Version = "1.0.3"; // Version of the Mod.  (MUST BE SET)
		public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)    
	}
	public class MassTooglePrioritize:MelonMod
    {
        public override void OnApplicationStart()
        {
			MelonLogger.Msg("MassTooglePrioritizeMod started");
        }
        public override void OnUpdate()
        {
			if (Input.GetMouseButtonDown(1))
			{
				var gameManager = GameObject.FindObjectOfType<GameManager>();
				if (gameManager == null)
				{
					return;
				}
				var selectedObj = GameObject.FindObjectOfType<UIBuildsiteWindow_New>();
				if (selectedObj != null)
				{
					bool prioritizedToggle = !selectedObj.prioritizedToggle.isOn;
					var objectToPrioritizeList = GameObject.FindObjectsOfType<BuildSite>();
					foreach (var objectToPrioritize in objectToPrioritizeList)
					{
						var buildSiteResource = objectToPrioritize.GetComponent<BuildSiteResource>();
						var selectedBuildSiteResource = selectedObj.buildsiteResource;
						if(buildSiteResource != null && selectedBuildSiteResource != null)
                        {
							var selectedConstructionData = selectedBuildSiteResource.constructionData;
							if (buildSiteResource.prefabToConstruct.name == selectedConstructionData.prefabToConstruct.name)
							{
								objectToPrioritize.prioritizeConstruction = prioritizedToggle;
								selectedObj.prioritizedToggle.isOn = prioritizedToggle;
							}
						}
						
					}
				}
			}
		}
    }
}
