using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class DevShardionHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shardion's Smissmas Stacker");
	    Tooltip.SetDefault("'Gauranteed to make you feel festive!'");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 23;
            item.rare = -12;
            item.vanity = true;
        }

	public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
	{
	    drawAltHair = true;
	}
    }
}
