using MelonLoader;
using Il2Cpp;
using dante_raidou_buff;
using HarmonyLib;

[assembly: MelonInfo(typeof(DanteRaidouBuff), "Dante/Raidou buff", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace dante_raidou_buff;
public class DanteRaidouBuff : MelonMod
{
    [HarmonyPatch(typeof(datSkillHelp_msg), nameof(datSkillHelp_msg.Get))]
    private class Patch
    {
        // Token: 0x06000050 RID: 80 RVA: 0x00003E98 File Offset: 0x00002098
        public static void Postfix(ref int id, ref string __result)
        {
            switch (id)
            {
                case 265:
                    __result = "Greatly lower all foes' \nDefense. \nUser: Slight MP recovery.";
                    break;
                case 274:
                    __result = "Negates -nda effects \nand raises the party's \nPhysical/Magical Attack.";
                    break;
                default:
                    break;
            }
        }
    }

    // When launching the game
    public override void OnInitializeMelon()
    {
        // Buffs Raptor Guardian
        datNormalSkill.tbl[274].hojotype = 262149; // Dekunda + Tarukaja + Makakaja
        datNormalSkill.tbl[274].cost = 50;

        // Buffs Provoke
        datNormalSkill.tbl[265].hojotype = 128; // Rakunda + Rakunda
    }
}
