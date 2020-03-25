using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck
{

	public class FirstPlayer : ModPlayer
	{
		public bool cacoPet;

		public override void ResetEffects()
		{
			cacoPet = false;
		}
	}
}