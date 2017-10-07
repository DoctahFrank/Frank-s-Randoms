using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Doors
{
    public class OldWoodDoor : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Old Wooden Door";
            item.width = 18;
            item.height = 32;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 40;
            item.createTile = mod.TileType("OldWoodDoor");
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