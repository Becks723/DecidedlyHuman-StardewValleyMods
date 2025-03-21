﻿namespace SmartBuilding
{
    /// <summary>
    /// We have slightly different placement logic for each of these, so we need a way to identify them.
    /// </summary>
    public enum ItemType
    {
        /// <summary>
        /// A Stardew Valley Fence. This is a special case, so we need to be able to identify a fence specifically.
        /// </summary>
        Fence,

        /// <summary>
        /// A Stardew Valley floor, which is a TerrainFeature.
        /// </summary>
        Floor,

        /// <summary>
        /// A Stardew Valley chest. This needs somewhat special handling.
        /// </summary>
        Chest,

        /// <summary>
        /// A Stardew Valley grass starter.
        /// </summary>
        GrassStarter,

        /// <summary>
        /// A Stardew Valley crab pot.
        /// </summary>
        CrabPot,

        /// <summary>
        /// Since seeds need very special treatment, this is important.
        /// </summary>
        Seed,

        /// <summary>
        /// Fertilizers also require special treatment.
        /// </summary>
        Fertilizer,

        /// <summary>
        /// Tree fertilizers also require special treatment.
        /// </summary>
        TreeFertilizer,

        /// <summary>
        /// Tappers need slightly special logic.
        /// </summary>
        Tapper,

        /// <summary>
        /// Stardew Valley Furniture. This is so we can apply special placement logic.
        /// </summary>
        GenericFurniture,

        /// <summary>
        /// We need to use the constructor for this.
        /// </summary>
        BedFurniture,

        /// <summary>
        /// We need to use the constructor for this.
        /// </summary>
        StorageFurniture,

        /// <summary>
        /// We need to use the constructor for this.
        /// </summary>
        FishTankFurniture,

        /// <summary>
        /// We need to use the constructor for this.
        /// </summary>
        TvFurniture,

        /// <summary>
        /// A generic placeable object.
        /// </summary>
        Generic,
		
		/// <summary>
		/// This object is not placeable.
		/// </summary>
		NotPlaceable
    }
}