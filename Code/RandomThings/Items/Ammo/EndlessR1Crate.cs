﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessR1Crate : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Rocket I Crate";
            item.shoot = 0;
            item.damage = 40;
            item.width = 34;
            item.height = 34;
            item.ammo = 771;
            item.knockBack = 4f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 2;
            item.consumable = false;
            item.toolTip = "Small blast radius. Will not destroy tiles";
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RocketI, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
