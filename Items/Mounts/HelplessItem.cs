using FirstModOhFuck.Mounts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace FirstModOhFuck.Items.Mounts
{
	public class HelplessItem : ModItem
	{
	    
		public override void SetStaticDefaults() {
		        DisplayName.SetDefault("Helpless Duck");
		        Tooltip.SetDefault("This is a modded mount.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 32));
			
		}

		public override void SetDefaults() {
			item.width = 100;
			item.height = 116;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = MountType<Helpless>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Duck, 300);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
