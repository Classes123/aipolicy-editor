using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_76
{
	public int uSkill { get; set; }

	public CTriggerData.enumPolicyVarType uSkillType { get; set; }

	public int uLevel { get; set; }

	public CTriggerData.enumPolicyVarType uLevelType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_76");
	}

	public static O_76 Read(BinaryReader br)
	{
		return new O_76
		{
			uSkill = br.ReadInt32(),
			uSkillType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			uLevel = br.ReadInt32(),
			uLevelType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_76 param)
	{
		bw.Write(param.uSkill);
		bw.Write((int)param.uSkillType);
		bw.Write(param.uLevel);
		bw.Write((int)param.uLevelType);
	}

	public object Copy()
	{
		return new O_76
		{
			uSkill = uSkill,
			uSkillType = uSkillType,
			uLevel = uLevel,
			uLevelType = uLevelType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uSkill, str) || Check.CheckValue(uSkillType, str) || Check.CheckValue(uLevel, str) || Check.CheckValue(uLevelType, str))
		{
			return true;
		}
		return false;
	}
}
