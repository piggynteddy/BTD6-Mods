﻿using Assets.Scripts.Unity.UI_New.Main.EventPanel;
using Harmony;

namespace Baby_Mode.Patches
{
    [HarmonyPatch(typeof(MainMenuEventPanel), "OpenRaceEventScreen")]
    internal class MainMenuEventPanel_OpenRaceEventScreen_Patch
    {
        [HarmonyPostfix]
        internal static void Postfix()
        {
            MelonMain.isInRace = true;
            MelonMain.shownInGameMsg = false;
        }
    }
}
