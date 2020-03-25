using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FirstModOhFuck.Buffs
{
	public class CacoPet : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Baby Cacodemon");
			Description.SetDefault("The fires within burn eternally");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<FirstPlayer>().cacoPet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.Pets.CacoPet>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ProjectileType<Projectiles.Pets.CacoPet>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}