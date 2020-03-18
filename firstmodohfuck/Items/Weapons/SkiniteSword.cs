using Terraria.ID;
using Terraria.ModLoader;

namespace firstmodohfuck.Items.Tools
{
	public class SkiniteSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Boil Blade");
			Tooltip.SetDefault("'The boils strain to keep from popping...'");
		}

		public override void SetDefaults() 
		{
			item.damage = 82;
			item.melee = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 8;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}