using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SUMMON_MONSTER_2
{
	public CTriggerData.enumPolicySummoneeDisppearType iDispearCondition { get; set; }

	public int iMonsterID { get; set; }

	public CTriggerData.enumPolicyVarType iMonsterIDType { get; set; }

	public int iRange { get; set; }

	public int iLife { get; set; }

	public int iPathID { get; set; }

	public CTriggerData.enumPolicyVarType iPathIDType { get; set; }

	public int iMonsterNum { get; set; }

	public CTriggerData.enumPolicyVarType iMonsterNumType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SUMMON_MONSTER_2");
	}

	public static O_SUMMON_MONSTER_2 Read(BinaryReader br)
	{
		return new O_SUMMON_MONSTER_2
		{
			iDispearCondition = (CTriggerData.enumPolicySummoneeDisppearType)br.ReadInt32(),
			iMonsterID = br.ReadInt32(),
			iMonsterIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iRange = br.ReadInt32(),
			iLife = br.ReadInt32(),
			iPathID = br.ReadInt32(),
			iPathIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iMonsterNum = br.ReadInt32(),
			iMonsterNumType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_SUMMON_MONSTER_2 param)
	{
		bw.Write((int)param.iDispearCondition);
		bw.Write(param.iMonsterID);
		bw.Write((int)param.iMonsterIDType);
		bw.Write(param.iRange);
		bw.Write(param.iLife);
		bw.Write(param.iPathID);
		bw.Write((int)param.iPathIDType);
		bw.Write(param.iMonsterNum);
		bw.Write((int)param.iMonsterNumType);
	}

	public object Copy()
	{
		return new O_SUMMON_MONSTER_2
		{
			iDispearCondition = iDispearCondition,
			iMonsterID = iMonsterID,
			iMonsterIDType = iMonsterIDType,
			iRange = iRange,
			iLife = iLife,
			iPathID = iPathID,
			iPathIDType = iPathIDType,
			iMonsterNum = iMonsterNum,
			iMonsterNumType = iMonsterNumType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iDispearCondition, str) || Check.CheckValue(iMonsterID, str) || Check.CheckValue(iMonsterIDType, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iLife, str) || Check.CheckValue(iPathID, str) || Check.CheckValue(iPathIDType, str) || Check.CheckValue(iMonsterNum, str) || Check.CheckValue(iMonsterNumType, str))
		{
			return true;
		}
		return false;
	}
}
