using GameNetcodeStuff;

public static class PlayerControllerB_Ext
{
    public static void RemovePartyHat(this PlayerControllerB target)
    {
        var HatRoot = target.transform.Find("ScavengerModel/metarig/spine/spine.001/spine.002/spine.003/spine.004/HatContainer/PartyHatContainer(Clone)/BirthdayHat");
        var HatRootLocal = target.transform.Find("ScavengerModel/metarig/CameraContainer/MainCamera/HatContainerLocal/PartyHatContainer(Clone)/BirthdayHat");

        if (HatRoot != null)
        {
            Plugin.Log.LogMessage($"Removing hat root from player {target.name}");
            HatRoot.gameObject.SetActive(false);
        }

        if (HatRootLocal != null)
        {
            Plugin.Log.LogMessage($"Removing local hat root from player {target.name}");
            HatRootLocal.gameObject.SetActive(false);
        }
    }
}
