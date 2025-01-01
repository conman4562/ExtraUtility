using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEngine.Rendering.DebugUI;
using Zorro.Settings;
using UnityEngine;
using Unity.Mathematics;

namespace ExtraUtility
{
    [ContentWarningSetting]
    public class RagdollSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"ragdollsetting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggle Anti-Ragdoll";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }

    /*[ContentWarningSetting]
    public class AntiPushSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"antipushsetting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggle Anti-Push";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }*/

    [ContentWarningSetting]
    public class UnlimitedStaminaSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"unlimitedstamina setting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggle Unlimited Stamina";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }

    [ContentWarningSetting]
    public class UnlimitedOxygenSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"unlimitedoxygen setting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggle Unlimited Oxygen";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }
    [ContentWarningSetting]
    public class UnlimitedHealthSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"unlimitedhealth setting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggle Unlimited Health";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }
    [ContentWarningSetting]
    public class ToggleCanSprintInAnyDirectionSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"ToggleCanSprintInAnyDirection setting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Toggles sprinting in all directions";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }
    /*
    [ContentWarningSetting]
    public class ToggleFlightSetting : BoolSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"toggleflight setting: {Value}");
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;
        public string GetDisplayName() => "ExtraUtility: Does nothing";
        public override bool GetDefaultValue()
        {
            return false;
        }
    }*/
    

    //-----SLIDERS------
    [ContentWarningSetting]
    public class SpeedSetting : FloatSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"speed setting: {Value}");

        public override float GetDefaultValue() => 10;
        public override float2 GetMinMaxValue() => new float2(0, 100);

        // Prefer using the Mods category
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;

        public string GetDisplayName() => "ExtraUtility: Speed Modifier (Default: 10)";
    }

/*    [ContentWarningSetting]
    public class JumpSetting : FloatSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"jump setting: {Value}");

        public override float GetDefaultValue() => 1;
        public override float2 GetMinMaxValue() => new float2(0, 500);

        // Prefer using the Mods category
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;

        public string GetDisplayName() => "ExtraUtility: Jump Modifier (Default: 1)";
    }

    [ContentWarningSetting]
    public class PersonalGravitySetting : FloatSetting, IExposedSetting
    {
        public override void ApplyValue() => Debug.Log($"personal gravity setting: {Value}");

        public override float GetDefaultValue() => 20;
        public override float2 GetMinMaxValue() => new float2(-100, 100);

        // Prefer using the Mods category
        public SettingCategory GetSettingCategory() => SettingCategory.Mods;

        public string GetDisplayName() => "ExtraUtility: Personal Gravity Modifier (Default: 20)";
    }*/
}
