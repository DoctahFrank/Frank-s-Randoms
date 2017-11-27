using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class ReplicatingNanoBullet : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Replicating Nano Bullet";
            item.shootSpeed = 5.1f;
            item.shoot = ProjectileID.NanoBullet;
            item.damage = 10;
            item.width = 26;
            item.height = 14;
            item.ammo = 14;
            item.knockBack = 5f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 4;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NanoBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
