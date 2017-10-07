using Terraria.ID;
using Terraria.ModLoader;

namespace FranksMod.Items.Placeable.Decor
{
    public class SoftDrink : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Soft Drink";
            item.width = 14;
            item.height = 32;
            item.maxStack = 99;
            AddTooltip("Bubbly and sugary.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 500;
            item.createTile = mod.TileType("SoftDrink");
        }
    }
}