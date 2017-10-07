using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Ammo
{
    public class BottomlessPartyBox : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bottomless Party Box";
            item.shootSpeed = 5.1f;
            item.shoot = ProjectileID.PartyBullet;
            item.damage = 10;
            item.width = 32;
            item.height = 30;
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
            recipe.AddIngredient(ItemID.PartyBullet, 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
