using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    public class DevEggHoodie : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Egg's Hoodie");
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