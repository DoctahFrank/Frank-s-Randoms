using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Doors
{
    public class StableDoor : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Stable Door";
            item.width = 28;
            item.height = 48;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 40;
            item.createTile = mod.TileType("StableDoor");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 6);
            recipe.AddCraftGroup(CraftGroup.IronBar, 2);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}