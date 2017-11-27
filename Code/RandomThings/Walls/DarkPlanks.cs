using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace RandomThings.Walls
{
    public class DarkPlanks : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = 7;                           // Wood dust
            drop = mod.ItemType("DarkPlanks");
            AddMapEntry(new Color(140, 87, 69));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
