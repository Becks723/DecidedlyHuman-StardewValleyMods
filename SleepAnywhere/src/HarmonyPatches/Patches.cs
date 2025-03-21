﻿using StardewModdingAPI;
using StardewValley;
using StardewValley.Objects;
using xTile.Dimensions;
using SObject = StardewValley.Object;
// ReSharper disable InconsistentNaming

namespace SleepAnywhere.HarmonyPatches
{
    public static class Patches
	{
		private static IMonitor logger;

		public static void Initialise(IMonitor logger)
		{
			Patches.logger = logger;
		}

		public static void BedFurniture_PlacementAction_Postfix(BedFurniture __instance, ref bool __result)
		{
            if (__instance.Name.Equals("Portable Bed"))
            {
                logger.Log("Placing our Portable Bed.");

                __result = true;
            }
		}

        public static void Utility_PlayerCanPlaceItemHere_Postfix(Item item, ref bool __result)
        {
            if (item.Name.Equals("DecidedlyHuman.SleepAnywhereItems/Portable Bed"))
            {
                logger.Log("Placing our Portable Bed.");

                __result = true;
            }
        }
    }
}