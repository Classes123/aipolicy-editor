using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_74
{
	public POLICY_CONTROLLER_LIST[] unk1 { get; set; } = new POLICY_CONTROLLER_LIST[6];


	public int unk2 { get; set; }

	public int uSkill { get; set; }

	public CTriggerData.enumPolicyVarType uSkillType { get; set; }

	public int uLevel { get; set; }

	public CTriggerData.enumPolicyVarType uLevelType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_74");
	}

	public static O_74 Read(BinaryReader br)
	{
		O_74 o_ = new O_74();
		for (int i = 0; i < 6; i++)
		{
			o_.unk1[i] = POLICY_CONTROLLER_LIST.Read(br);
		}
		o_.unk2 = br.ReadInt32();
		o_.uSkill = br.ReadInt32();
		o_.uSkillType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_.uLevel = br.ReadInt32();
		o_.uLevelType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		return o_;
	}

	public static void Write(BinaryWriter bw, O_74 param)
	{
		for (int i = 0; i < 6; i++)
		{
			POLICY_CONTROLLER_LIST.Write(bw, param.unk1[i]);
		}
		bw.Write(param.unk2);
		bw.Write(param.uSkill);
		bw.Write((int)param.uSkillType);
		bw.Write(param.uLevel);
		bw.Write((int)param.uLevelType);
	}

	public object Copy()
	{
		O_74 o_ = new O_74();
		for (int i = 0; i < 6; i++)
		{
			o_.unk1[i] = unk1[i].Copy();
		}
		o_.unk2 = unk2;
		o_.uSkill = uSkill;
		o_.uSkillType = uSkillType;
		o_.uLevel = uLevel;
		o_.uLevelType = uLevelType;
		return o_;
	}

	public bool Search(string str)
	{
		for (int i = 0; i < 6; i++)
		{
			if (unk1[i].Search(str))
			{
				return true;
			}
		}
		if (Check.CheckValue(unk2, str))
		{
			return true;
		}
		if (Check.CheckValue(uSkill, str))
		{
			return true;
		}
		if (Check.CheckValue(uSkillType, str))
		{
			return true;
		}
		if (Check.CheckValue(uLevel, str))
		{
			return true;
		}
		if (Check.CheckValue(uLevelType, str))
		{
			return true;
		}
		return false;
	}
}
