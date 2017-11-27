using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessChlorophytePouch : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Chlorophyte Pouch";
            item.shootSpeed = 5f;
            item.shoot = ProjectileID.ChlorophyteBullet;
            item.damage = 10;
            item.width = 26;
            item.height = 34;
            item.ammo = 14;
            item.knockBack = 4.5f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 8;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
