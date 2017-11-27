using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessR4Crate : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Rocket IV Crate";
            item.shoot = 9;
            item.damage = 65;
            item.width = 34;
            item.height = 34;
            item.ammo = 771;
            item.knockBack = 6f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 2;
            item.consumable = false;
            item.toolTip = "Large blast radius. Will destroy tiles";
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RocketIV, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
