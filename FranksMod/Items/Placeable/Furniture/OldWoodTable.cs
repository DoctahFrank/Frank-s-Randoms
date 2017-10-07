using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Furniture
{
    public class OldWoodTable : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Old Wooden Table";
            item.width = 30;
            item.height = 22;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 60;
            item.createTile = mod.TileType("OldWoodTable");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}