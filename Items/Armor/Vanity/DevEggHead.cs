using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class DevEggHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Egg's Head");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 24;
            item.rare = -12;
            item.vanity = true;
        }
    }
}