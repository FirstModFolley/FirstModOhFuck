using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Projectiles.Pets
{
	public class CacoPet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			FirstPlayer modPlayer = player.GetModPlayer<FirstPlayer>();
			if (player.dead)
			{
				modPlayer.cacoPet = false;
			}
			if (modPlayer.cacoPet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}