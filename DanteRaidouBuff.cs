using MelonLoader;
using Il2Cpp;
using dante_raidou_buff;

[assembly: MelonInfo(typeof(DanteRaidouBuff), "Dante/Raidou buff", "1.0.0", "Matthiew Purple")]
[assembly: MelonGame("アトラス", "smt3hd")]

namespace dante_raidou_buff;
public class DanteRaidouBuff : MelonMod
{
    // When launching the game
    public override void OnInitializeMelon()
    {
        byte danteID = 192;

        // Adds Avenge at level 85
        tblSkill.fclSkillTbl[danteID].Event[12].TargetLevel = 85;
        tblSkill.fclSkillTbl[danteID].Event[12].Param = 307;
        tblSkill.fclSkillTbl[danteID].Event[12].Type = 1;

        // Adds Might at level 86
        tblSkill.fclSkillTbl[danteID].Event[13].TargetLevel = 86;
        tblSkill.fclSkillTbl[danteID].Event[13].Param = 299;
        tblSkill.fclSkillTbl[danteID].Event[13].Type = 1;

        // Adds Focus at level 87
        tblSkill.fclSkillTbl[danteID].Event[14].TargetLevel = 87;
        tblSkill.fclSkillTbl[danteID].Event[14].Param = 224;
        tblSkill.fclSkillTbl[danteID].Event[14].Type = 1;

        // Adds Debilitate at level 88
        tblSkill.fclSkillTbl[danteID].Event[14].TargetLevel = 88;
        tblSkill.fclSkillTbl[danteID].Event[14].Param = 206;
        tblSkill.fclSkillTbl[danteID].Event[14].Type = 1;
    }
}
