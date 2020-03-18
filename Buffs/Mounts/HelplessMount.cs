using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace FirstModOhFuck.Buffs.Mounts
{
    public class HelplessMount : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Helpless");
			Description.SetDefault("A flightless, HELPLESS duck");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(MountType<FirstModOhFuck.Mounts.Helpless>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
