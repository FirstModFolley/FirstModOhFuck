using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace FirstModOhFuck.Items.Tools
{
    public class SkiniteHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plaquescratcher");
            Tooltip.SetDefault("'The teeth are yellow and rotting...'");
        }

        public override void SetDefaults()
        {
            item.damage = 96;
            item.width = 54;
            item.height = 46;
            item.useTime = 8;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.melee = true;
            item.axe = 24;
            item.hammer = 85;
            item.knockBack = 2;
            item.value = 1000;
            item.rare = 5;
            item.scale = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.tileBoost = 3;
        }
    }
}