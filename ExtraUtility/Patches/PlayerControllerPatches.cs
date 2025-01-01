using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ExtraUtility.Patches
{
    [HarmonyPatch(typeof(PlayerController))]
    public class PlayerControllerPatch
    {
        static SpeedSetting ss = null;
        // static JumpSetting js = null;
        // static PersonalGravitySetting pgs = null;
        static ToggleCanSprintInAnyDirectionSetting csd = null;
        [HarmonyPatch(nameof(PlayerController.Update))]
        [HarmonyPrefix]
        public static bool UpdatePatch(ref PlayerController __instance)
        {
            ss = GameHandler.Instance.SettingsHandler.GetSetting<SpeedSetting>();
            // js = GameHandler.Instance.SettingsHandler.GetSetting<JumpSetting>();
            // pgs = GameHandler.Instance.SettingsHandler.GetSetting<PersonalGravitySetting>();
            csd = GameHandler.Instance.SettingsHandler.GetSetting<ToggleCanSprintInAnyDirectionSetting>();
            if (__instance.player.IsLocal)
            {
                __instance.movementForce = ss.Value;
                // __instance.jumpForceDuration = js.Value;
                // __instance.gravity = pgs.Value;
                __instance.canSprintInAnyDirection = csd.Value;
                
            }
            return true;
        }

    }
}
