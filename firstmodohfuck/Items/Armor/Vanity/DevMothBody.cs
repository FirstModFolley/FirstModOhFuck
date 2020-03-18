using Terraria.ID;
using Terraria.ModLoader;

namespace firstmodohfuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    public class DevMothBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rosy Maple's Body");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 20;
            item.vanity = true;
            item.rare = -12;
        }
    }
}