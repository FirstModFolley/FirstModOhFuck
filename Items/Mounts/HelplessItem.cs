using FirstModOhFuck.Mounts;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FirstModOhFuck.Items.Mounts
{
	public class HelplessItem : ModItem
	{

	        public override string Texture => "FirstModOhFuck/Items/Placeholder";
	    
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded mount.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
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
