using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class DevEggPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Egg's Pants");
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