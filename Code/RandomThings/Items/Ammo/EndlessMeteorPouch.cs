using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class EndlessMeteorPouch : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Endless Meteor Pouch";
            item.shootSpeed = 3f;
            item.shoot = ProjectileID.MeteorShot;
            item.damage = 9;
            item.width = 26;
            item.height = 34;
            item.ammo = 14;
            item.knockBack = 1f;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.ranged = true;
            item.rare = 2;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteorShot, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
