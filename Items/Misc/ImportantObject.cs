using Terraria.ID;
using Terraria.ModLoader;

namespace firstmodohfuck.Items.Misc
{
	public class ImportantObject : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Moth Plush");
			Tooltip.SetDefault("Untold power lies in its unblinking, soulless eyes...");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 34;
            item.useStyle = 4;
			item.useTime = 79;
			item.useAnimation = 79;
			item.value = 10000;
			item.rare = -12;
            item.autoReuse = false;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/MothScream");
		}
	}
}