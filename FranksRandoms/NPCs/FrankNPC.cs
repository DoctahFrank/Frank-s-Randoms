using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FranksRandoms.NPCs
{
    public class FrankNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Dryad:
                    if(NPC.downedMechBossAny)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.NightKey);
                        shop.item[nextSlot].shopCustomPrice = 150000;
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.LightKey);
                        shop.item[nextSlot].shopCustomPrice = 150000;
                        nextSlot++;
                    }
                    break;

                case NPCID.Merchant:
                    shop.item[nextSlot].SetDefaults(ItemID.Chest);
                    shop.item[nextSlot].shopCustomPrice = 1000;
                    nextSlot++;
                    if(NPC.downedBoss1)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.GoldChest);
                        shop.item[nextSlot].shopCustomPrice = 2500;
                        nextSlot++;
                    }
                    break;

                case NPCID.GoblinTinkerer:
                    if (NPC.downedPlantBoss)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
                        shop.item[nextSlot].shopCustomPrice = 1000000;
                        nextSlot++;
                        shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
                        shop.item[nextSlot].shopCustomPrice = 1000000;
                        nextSlot++;
                    }
                    break;
            }
        }
    }
}