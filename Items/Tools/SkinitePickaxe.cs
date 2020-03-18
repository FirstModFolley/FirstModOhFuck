using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace FirstModOhFuck.Items.Tools
{
	public class SkinitePickaxe : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tickler");
            Tooltip.SetDefault("'It's reaching for you...'");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.width = 50;
            item.height = 50;
            item.useTime = 7;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.melee = true;
            item.pick = 150;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.tileBoost = 2;
        }
    }
}