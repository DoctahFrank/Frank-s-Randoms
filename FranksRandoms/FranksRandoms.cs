using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FranksRandoms
{
	class FranksRandoms : Mod
	{
		public FranksRandoms()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.BlueandBlackDye, 1);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.MiningShirt, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.BlueandBlackDye, 1);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.MiningPants, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 15);
            recipe.AddIngredient(ItemID.SpellTome);
            recipe.AddIngredient(ItemID.BossTrophyOgre);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.BookStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddIngredient(ItemID.BossTrophyOgre);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DD2PhoenixBow);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddRecipeGroup("IronBar", 3);
            recipe.AddIngredient(ItemID.BossTrophyOgre);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.DD2SquireDemonSword);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Coral, 10);
            recipe.AddIngredient(ItemID.Seashell, 3);
            recipe.AddIngredient(ItemID.Starfish, 3);
            recipe.AddIngredient(ItemID.BossTrophyOgre);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MonkStaffT1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddIngredient(ItemID.BossTrophyOgre);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MonkStaffT2);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("FranksRandoms:GoldBars", 10);
            recipe.AddIngredient(ItemID.AncientCloth, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.DjinnLamp);
            recipe.AddRecipe();
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[]
            {
                ItemID.GoldBar,
                ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("FranksRandoms:GoldBars", group);
        }
    }
}
