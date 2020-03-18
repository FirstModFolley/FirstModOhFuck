using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class DevMothHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rosy Maple's Head");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.rare = -12;
            item.vanity = true;
        }
    }
}