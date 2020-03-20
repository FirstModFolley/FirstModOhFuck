using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    public class DevShardionSuit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shardion's Scorching Suit");
	    Tooltip.SetDefault("'Makes you want to burn something.'");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.vanity = true;
            item.rare = -12;
        }
    }
}
