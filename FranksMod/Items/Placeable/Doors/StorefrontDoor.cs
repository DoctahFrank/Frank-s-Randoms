﻿using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Doors
{
    public class StorefrontDoor : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Storefront Door";
            item.width = 28;
            item.height = 48;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 40;
            item.createTile = mod.TileType("StorefrontDoor");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddIngredient(ItemID.Glass, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}