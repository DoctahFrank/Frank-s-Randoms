using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Decor
{
    public class ExoticDrink : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Exotic Drink";
            item.width = 16;
            item.height = 32;
            item.maxStack = 99;
            AddTooltip("Comes from a far-away land.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 500;
            item.createTile = mod.TileType("ExoticDrink");
        }
    }
}