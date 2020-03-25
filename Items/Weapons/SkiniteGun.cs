using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace FirstModOhFuck.Items.Weapons
{
	public class SkiniteGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Screamer");
			Tooltip.SetDefault("'Its shots echo with the pain it endures...'\nShoots a powerful, high velocity... bone?\nUses bones as ammo.");
		}

		public override void SetDefaults()
		{
			item.damage = 104;
			item.ranged = true;
			item.width = 64;
			item.height = 64;
			item.useTime = 42;
			item.useAnimation = 42;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/GunScream");
			item.autoReuse = true;
			item.useAmmo = ItemID.Bone;
			item.noMelee = true;
			item.shoot = 532;
			item.shootSpeed = 30f;
		}		// Help, my gun isn't being held at the handle! Adjust these 2 numbers until it looks right.
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(10, 0);
		}
	}
}
