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
	}
}
