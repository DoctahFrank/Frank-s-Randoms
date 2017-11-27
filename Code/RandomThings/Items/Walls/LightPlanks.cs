using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings.Items.Walls
{
    public class LightPlanks : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Light Planks";
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            AddTooltip("Light planks with a baseboard.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;
            item.useStyle = 1;
            item.consumable = true;
            item.createWall = mod.WallType("LightPlanks");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}
