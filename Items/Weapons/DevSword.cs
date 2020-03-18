using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Weapons
{
	public class DevSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pog Pike");
			Tooltip.SetDefault("Are you sure you're supposed to have this?");
		}

		public override void SetDefaults() 
		{
			item.damage = 69696969;
			item.melee = true;
			item.width = 150;
			item.height = 150;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = -12;
			item.scale = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;

		}
	}
}