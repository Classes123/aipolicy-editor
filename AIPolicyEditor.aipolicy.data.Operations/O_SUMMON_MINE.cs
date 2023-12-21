using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SUMMON_MINE
{
	private byte[] bytes = new byte[3];

	public CTriggerData.enumPolicySummoneeDisppearType iLifeType { get; set; }

	public int iMineID { get; set; }

	public CTriggerData.enumPolicyVarType iMineIDType { get; set; }

	public int iRange { get; set; }

	public int iLife { get; set; }

	public int iMineNum { get; set; }

	public CTriggerData.enumPolicyVarType iMineNumType { get; set; }

	public bool unk { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SUMMON_MINE");
	}

	public static O_SUMMON_MINE Read(BinaryReader br, int version)
	{
		O_SUMMON_MINE o_SUMMON_MINE = new O_SUMMON_MINE();
		o_SUMMON_MINE.iLifeType = (CTriggerData.enumPolicySummoneeDisppearType)br.ReadInt32();
		o_SUMMON_MINE.iMineID = br.ReadInt32();
		o_SUMMON_MINE.iMineIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_SUMMON_MINE.iRange = br.ReadInt32();
		o_SUMMON_MINE.iLife = br.ReadInt32();
		o_SUMMON_MINE.iMineNum = br.ReadInt32();
		o_SUMMON_MINE.iMineNumType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		if (version >= 24)
		{
			o_SUMMON_MINE.unk = br.ReadBoolean();
			o_SUMMON_MINE.bytes = br.ReadBytes(3);
		}
		return o_SUMMON_MINE;
	}

	public static void Write(BinaryWriter bw, O_SUMMON_MINE param, int version)
	{
		bw.Write((int)param.iLifeType);
		bw.Write(param.iMineID);
		bw.Write((int)param.iMineIDType);
		bw.Write(param.iRange);
		bw.Write(param.iLife);
		bw.Write(param.iMineNum);
		bw.Write((int)param.iMineNumType);
		if (version >= 24)
		{
			bw.Write(param.unk);
			bw.Write(param.bytes);
		}
	}

	public object Copy()
	{
		return new O_SUMMON_MINE
		{
			iLifeType = iLifeType,
			iMineID = iMineID,
			iMineIDType = iMineIDType,
			iRange = iRange,
			iLife = iLife,
			iMineNum = iMineNum,
			iMineNumType = iMineNumType,
			unk = unk
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iLifeType, str) || Check.CheckValue(iMineID, str) || Check.CheckValue(iMineIDType, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iLife, str) || Check.CheckValue(iMineNum, str) || Check.CheckValue(iMineNumType, str) || Check.CheckValue(unk, str))
		{
			return true;
		}
		return false;
	}
}
