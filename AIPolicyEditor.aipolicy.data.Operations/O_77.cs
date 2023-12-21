using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_77
{
	public int uSkill { get; set; }

	public CTriggerData.enumPolicyVarType uSkillType { get; set; }

	public int uLevel { get; set; }

	public CTriggerData.enumPolicyVarType uLevelType { get; set; }

	public int iMonsterID { get; set; }

	public int unk4 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_77");
	}

	public static O_77 Read(BinaryReader br)
	{
		return new O_77
		{
			uSkill = br.ReadInt32(),
			uSkillType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			uLevel = br.ReadInt32(),
			uLevelType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iMonsterID = br.ReadInt32(),
			unk4 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_77 param)
	{
		bw.Write(param.uSkill);
		bw.Write((int)param.uSkillType);
		bw.Write(param.uLevel);
		bw.Write((int)param.uLevelType);
		bw.Write(param.iMonsterID);
		bw.Write(param.unk4);
	}

	public object Copy()
	{
		return new O_77
		{
			uSkill = uSkill,
			uSkillType = uSkillType,
			uLevel = uLevel,
			uLevelType = uLevelType,
			iMonsterID = iMonsterID,
			unk4 = unk4
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uSkill, str) || Check.CheckValue(uSkillType, str) || Check.CheckValue(uLevel, str) || Check.CheckValue(uLevelType, str) || Check.CheckValue(iMonsterID, str) || Check.CheckValue(unk4, str))
		{
			return true;
		}
		return false;
	}
}
