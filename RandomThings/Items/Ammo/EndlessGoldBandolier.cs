﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessGoldBandolier : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Gold Bandolier";
            item.shootSpeed = 4.6f;
            item.shoot = ProjectileID.GoldenBullet;
            item.damage = 10;
            item.width = 34;
            item.height = 16;
            item.ammo = 14;
            item.knockBack = 3.6f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 4;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldenBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
