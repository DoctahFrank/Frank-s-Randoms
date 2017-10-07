﻿using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Furniture
{
    public class ContainerBed : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Drawer Bed";
            item.width = 50;
            item.height = 22;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 400;
            item.createTile = mod.TileType("ContainerBed");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddCraftGroup(CraftGroup.IronBar, 1);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}