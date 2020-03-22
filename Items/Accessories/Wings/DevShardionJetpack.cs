using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;

namespace FirstModOhFuck.Items.Accessories.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class DevShardionJetpack : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shardion's Thermal Thruster");
	    Tooltip.SetDefault("'Now with a name ripped directly from the source material!'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.value = 1000000;
            item.rare = -12;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)

        {
            player.wingTimeMax = 2000;
            player.wingTime = player.wingTimeMax;
            player.ignoreWater = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.25f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 18f;
            acceleration *= 3.5f;
        }
    }
}
