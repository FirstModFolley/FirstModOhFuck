using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FirstModOhFuck.NPCs.ClownInvasion
{
    // Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
    public class BasicClown : ModNPC
    {
	public override void SetStaticDefaults() {
	    DisplayName.SetDefault("Zombie");
	    Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
	}

	public override void SetDefaults() {
	    npc.width = 18;
	    npc.height = 40;
	    npc.damage = 14;
	    npc.defense = 6;
	    npc.lifeMax = 200;
	    npc.HitSound = SoundID.NPCHit1;
	    npc.DeathSound = SoundID.NPCDeath2;
	    npc.value = 60f;
	    npc.knockBackResist = 0.5f;
	    npc.aiStyle = 3;
	    aiType = NPCID.Zombie;
	    animationType = NPCID.Zombie;
	    // banner = Item.NPCtoBanner(NPCID.Zombie);
	    // bannerItem = Item.BannerToItem(banner);
	}
    }
}
