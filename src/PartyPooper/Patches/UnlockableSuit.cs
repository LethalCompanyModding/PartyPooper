using HarmonyLib;
using GameNetcodeStuff;

namespace PartyPooper.Patches;

public class UnlockableSuit_Patches
{
    [HarmonyPatch(typeof(UnlockableSuit), nameof(UnlockableSuit.SwitchSuitForPlayer))]
    [HarmonyPostfix]
    public static void Postfix(PlayerControllerB player)
    {
        Plugin.Log.LogInfo($"Player costume is being changed: {player.name}");
        player.RemovePartyHat();
    }
}
