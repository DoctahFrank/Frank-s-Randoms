using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Furniture
{
    public class StudentBookshelf : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Student Bookshelf";
            item.width = 48;
            item.height = 64;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 60;
            item.createTile = mod.TileType("StudentBookshelf");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.GrayBrick, 10);
            recipe.AddIngredient(ItemID.Book, 10);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}