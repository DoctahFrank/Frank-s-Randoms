using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Furniture
{
    public class BarTable : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bar Table";
            item.width = 30;
            item.height = 32;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 60;
            item.createTile = mod.TileType("BarTable");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 6);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}