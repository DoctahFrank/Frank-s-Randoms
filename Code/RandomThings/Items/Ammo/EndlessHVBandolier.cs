using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessHVBandolier : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless High Velocity Bandolier";
            item.shootSpeed = 28f;
            item.shoot = ProjectileID.BulletHighVelocity;
            item.damage = 10;
            item.width = 28;
            item.height = 16;
            item.ammo = 14;
            item.knockBack = 4f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 4;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HighVelocityBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
