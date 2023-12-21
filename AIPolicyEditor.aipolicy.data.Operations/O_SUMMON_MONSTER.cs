using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SUMMON_MONSTER
{
	public int iMonsterID { get; set; }

	public int iRange { get; set; }

	public int iLife { get; set; }

	public CTriggerData.enumPolicySummoneeDisppearType iDispearCondition { get; set; }

	public int iPathID { get; set; }

	public int iMonsterNum { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SUMMON_MONSTER");
	}

	public static O_SUMMON_MONSTER Read(BinaryReader br)
	{
		return new O_SUMMON_MONSTER
		{
			iMonsterID = br.ReadInt32(),
			iRange = br.ReadInt32(),
			iLife = br.ReadInt32(),
			iDispearCondition = (CTriggerData.enumPolicySummoneeDisppearType)br.ReadInt32(),
			iPathID = br.ReadInt32(),
			iMonsterNum = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_SUMMON_MONSTER param)
	{
		bw.Write(param.iMonsterID);
		bw.Write(param.iRange);
		bw.Write(param.iLife);
		bw.Write((int)param.iDispearCondition);
		bw.Write(param.iPathID);
		bw.Write(param.iMonsterNum);
	}

	public object Copy()
	{
		return new O_SUMMON_MONSTER
		{
			iMonsterID = iMonsterID,
			iRange = iRange,
			iLife = iLife,
			iDispearCondition = iDispearCondition,
			iPathID = iPathID,
			iMonsterNum = iMonsterNum
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iMonsterID, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iLife, str) || Check.CheckValue(iDispearCondition, str) || Check.CheckValue(iPathID, str) || Check.CheckValue(iMonsterNum, str))
		{
			return true;
		}
		return false;
	}
}
