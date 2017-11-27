using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Doors
{
    public class HeavyIronDoor : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Iron Door - Heavy";
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
            item.createTile = mod.TileType("HeavyIronDoor");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddCraftGroup(CraftGroup.IronBar, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}