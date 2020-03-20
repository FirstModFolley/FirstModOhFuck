using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace FirstModOhFuck.Projectiles.Weapons
{
	public class Airblast : ModProjectile
	{

	        public override string Texture => "FirstModOhFuck/Items/Placeholder";
           
	        public override void SetDefaults()
		{
			projectile.width = 64;
			projectile.height = 64;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
		}

		public override void AI()
		{
		       projectile.velocity.Y += projectile.ai[0];

		       foreach(var p in Main.projectile.Where(i => i.active && i.Hitbox.Intersects(projectile.Hitbox)))
		       {
			   p.friendly = true;
			   p.hostile = false;
			   p.velocity *= -1;
		       }
		       
		}
	    

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
			}
			else
			{
				projectile.ai[0] += 0.1f;
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
				projectile.velocity *= 1.75f;
				Main.PlaySound(SoundID.Item10, projectile.position);
			}
			return false;
		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(SoundID.Item25, projectile.position);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 1.75f;
		}
	}
}

