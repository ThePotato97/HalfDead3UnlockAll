using HarmonyLib;
using MelonLoader;

namespace HalfDead3Mod
{
    public class ModMain : MelonMod
    {

        [HarmonyPatch(typeof(AchievementManager), "get_beta_num")]
        private class GetBetaNumberPatch
        {
            private static bool Prefix(ref int __result)
            {
                __result = 30;
                return false;
            }
        }
    }
}
