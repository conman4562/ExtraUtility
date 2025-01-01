using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUtility.Patches
{
    [HarmonyPatch(typeof(Player))]
    public class PlayerPatches
    {
        static RagdollSetting rds = null;
        [HarmonyPatch(nameof(Player.Ragdoll))]
        [HarmonyPrefix]
        static bool RagdollPatch(ref Player __instance)
        {
            rds = GameHandler.Instance.SettingsHandler.GetSetting<RagdollSetting>();
            if (__instance.IsLocal && rds.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        [HarmonyPatch(nameof(Player.NoControl))]
        [HarmonyPrefix]
        static bool NoControlPatch(ref Player __instance)
        {
            rds = GameHandler.Instance.SettingsHandler.GetSetting<RagdollSetting>();
            if (__instance.IsLocal && rds.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // static AntiPushSetting aps = null;
        [HarmonyPatch(nameof(Player.CallTakeDamageAndAddForceAndFall))]
        [HarmonyPrefix]
        static bool CallTakeDamageAndAddForceAndFallPatch(ref Player __instance, ref float damage)
        {
           // aps = GameHandler.Instance.SettingsHandler.GetSetting<AntiPushSetting>();
           //  if (__instance.IsLocal && aps.Value)
           // {
           //     return false;
           // }
           // else
           // {
                return true;
           // }
        }
        static UnlimitedStaminaSetting uss = null;
        static UnlimitedHealthSetting uhs = null;
        static UnlimitedOxygenSetting uos = null;
        // static ToggleFlightSetting tfs = null;
        [HarmonyPatch(nameof(Player.Update))]
        [HarmonyPrefix]
        static bool UpdatePatch(ref Player __instance)
        {
            uss = GameHandler.Instance.SettingsHandler.GetSetting<UnlimitedStaminaSetting>();
            uhs = GameHandler.Instance.SettingsHandler.GetSetting<UnlimitedHealthSetting>();
            uos = GameHandler.Instance.SettingsHandler.GetSetting<UnlimitedOxygenSetting>();
            // tfs = GameHandler.Instance.SettingsHandler.GetSetting<ToggleFlightSetting>();
            if (__instance.IsLocal)
            {
                if (uss.Value)
                {
                    __instance.data.currentStamina = 10f;
                }
                if (uos.Value)
                {
                    __instance.data.remainingOxygen = __instance.data.maxOxygen;
                }
                if (uhs.Value)
                {
                    __instance.data.health = 99999;
                }
                else if (__instance.data.health > 100f)
                {
                    __instance.data.health = 100f;
                }
            }
            return true;
        }
    }
}
