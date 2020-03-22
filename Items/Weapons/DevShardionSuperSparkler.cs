/* code for later
this reflects shit, put in a projectile AI

foreach(var p in Main.projectile.Where(i => i.active && i.Hitbox.Intersects(projectile.Hitbox))){
    p.friendly = true;
    p.hostile = false;
    p.velocity *= -1; }

*/

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.Items.Weapons
{
	public class DevShardionSuperSparkler : ModItem
	{
	    
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shardion's Super Sparkler");
			Tooltip.SetDefault("'Get ze flammenwerfer!'\nRight click unleashes a blast of air that reflects projectiles");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Flamethrower);
			item.damage = (int)(item.damage * 1.5);
		}

	        public override bool AltFunctionUse(Player player)
	        {
		        return true;
		}

	        public override bool CanUseItem(Player player)
	        {
		    
	         	if (player.altFunctionUse == 2)
			{
			    item.shoot = mod.ProjectileType("Airblast");
			    item.shootSpeed = 2f;
			    item.useAnimation = 100;
			    item.useTime = 100;
			    item.ranged = true;
			}
			else
			{
			    item.shoot = 85;
			    item.shootSpeed = 7f;
			    item.useAnimation = 35;
			    item.useTime = 7;
			    item.ranged = true;
			}
			return true;
		}

	}

}
