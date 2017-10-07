using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace RandomThings.Walls
{
    public class LightPlanks : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = 7;                           // Wood dust
            drop = mod.ItemType("LightPlanks");
            AddMapEntry(new Color(158, 99, 79));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
