using Terraria.ID;
using Terraria.ModLoader;

namespace firstmodohfuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class DevMothLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rosy Maple's Legs");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.vanity = true;
            item.rare = -12;
        }
    }
}