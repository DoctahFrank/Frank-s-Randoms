using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace FranksRandoms.Tiles
{
    public class WoodSupport : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            dustType = 7;
            drop = mod.ItemType("WoodSupport");
            AddMapEntry(new Color(102, 51, 0));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
