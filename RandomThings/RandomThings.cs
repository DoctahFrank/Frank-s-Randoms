using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomThings
{
	public class RandomThings : Mod
	{

		public RandomThings()
		{
			Properties = new ModProperties()
			{
				Autoload = true
			};
		}

		public override void Load() // Manually load any assets
		{
			
		}

		public override void Unload() // Manually unload any assets
		{
			
		}

		public override void AddRecipeGroups() // Groups for items of one type (i.e. iron and lead bars)
		{
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
            {
                ItemID.SilverBar,
                ItemID.TungstenBar
            });
            RecipeGroup.RegisterGroup("SilverBar", group);
		}

		public override void AddRecipes() // Recipes for items not from this mod
		{
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "DarkPlanks", 4);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(ItemID.Wood, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "LightPlanks", 4);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(ItemID.Wood, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Chain, 3);
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddRecipeGroup("SilverBar", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.ChainKnife);
            recipe.AddRecipe();
		}

		public override void UpdateMusic(ref int music)
		{
			
		}

		public override void HotKeyPressed(string name) // Effects if a mod hotkey was pressed
		{
			
		}

		public override void ChatInput(string text)
		{
			
		}

		//spawning helper methods imported from my tAPI mod
		public static bool NoInvasion(NPCSpawnInfo spawnInfo)
		{
			return !spawnInfo.invasion && ((!Main.pumpkinMoon && !Main.snowMoon) || spawnInfo.spawnTileY > Main.worldSurface || Main.dayTime) && (!Main.eclipse || spawnInfo.spawnTileY > Main.worldSurface || !Main.dayTime);
		}

		public static bool NoBiome(NPCSpawnInfo spawnInfo)
		{
			Player player = spawnInfo.player;
			return !player.ZoneJungle && !player.ZoneDungeon && !player.ZoneCorrupt && !player.ZoneCrimson && !player.ZoneHoly && !player.ZoneSnow && !player.ZoneUndergroundDesert;
		}

		public static bool NoZoneAllowWater(NPCSpawnInfo spawnInfo)
		{
			return !spawnInfo.sky && !spawnInfo.player.ZoneMeteor && !spawnInfo.spiderCave;
		}

		public static bool NoZone(NPCSpawnInfo spawnInfo)
		{
			return NoZoneAllowWater(spawnInfo) && !spawnInfo.water;
		}

		public static bool NormalSpawn(NPCSpawnInfo spawnInfo)
		{
			return !spawnInfo.playerInTown && NoInvasion(spawnInfo);
		}

		public static bool NoZoneNormalSpawn(NPCSpawnInfo spawnInfo)
		{
			return NormalSpawn(spawnInfo) && NoZone(spawnInfo);
		}

		public static bool NoZoneNormalSpawnAllowWater(NPCSpawnInfo spawnInfo)
		{
			return NormalSpawn(spawnInfo) && NoZoneAllowWater(spawnInfo);
		}

		public static bool NoBiomeNormalSpawn(NPCSpawnInfo spawnInfo)
		{
			return NormalSpawn(spawnInfo) && NoBiome(spawnInfo) && NoZone(spawnInfo);
		}
	}
}