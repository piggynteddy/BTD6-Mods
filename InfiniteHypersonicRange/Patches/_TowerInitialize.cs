﻿using Assets.Scripts.Simulation.Towers;
using Harmony;

namespace InfiniteHypersonicRange.Patches
{
    [HarmonyPatch(typeof(Tower), "Initialise")]
    public class Tower_Initialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Tower __instance)
        {
            if (MelonMain.isInRace)
                return;

            if (Settings.settings.EnableInfiniteRange)
            {
                __instance.towerModel.range = 999999;
                __instance.towerModel.isGlobalRange = true;
            }
        }
    }
}
