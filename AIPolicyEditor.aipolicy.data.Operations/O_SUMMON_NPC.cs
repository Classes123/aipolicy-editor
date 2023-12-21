using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SUMMON_NPC
{
	public CTriggerData.enumPolicySummoneeDisppearType iLifeType { get; set; }

	public int iNPCID { get; set; }

	public CTriggerData.enumPolicyVarType iNPCIDType { get; set; }

	public int iRange { get; set; }

	public int iLife { get; set; }

	public int iPathID { get; set; }

	public CTriggerData.enumPolicyVarType iPathIDType { get; set; }

	public int iNPCNum { get; set; }

	public CTriggerData.enumPolicyVarType iNPCNumType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SUMMON_NPC");
	}

	public static O_SUMMON_NPC Read(BinaryReader br)
	{
		return new O_SUMMON_NPC
		{
			iLifeType = (CTriggerData.enumPolicySummoneeDisppearType)br.ReadInt32(),
			iNPCID = br.ReadInt32(),
			iNPCIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iRange = br.ReadInt32(),
			iLife = br.ReadInt32(),
			iPathID = br.ReadInt32(),
			iPathIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iNPCNum = br.ReadInt32(),
			iNPCNumType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_SUMMON_NPC param)
	{
		bw.Write((int)param.iLifeType);
		bw.Write(param.iNPCID);
		bw.Write((int)param.iNPCIDType);
		bw.Write(param.iRange);
		bw.Write(param.iLife);
		bw.Write(param.iPathID);
		bw.Write((int)param.iPathIDType);
		bw.Write(param.iNPCNum);
		bw.Write((int)param.iNPCNumType);
	}

	public object Copy()
	{
		return new O_SUMMON_NPC
		{
			iLifeType = iLifeType,
			iNPCID = iNPCID,
			iNPCIDType = iNPCIDType,
			iRange = iRange,
			iLife = iLife,
			iPathID = iPathID,
			iPathIDType = iPathIDType,
			iNPCNum = iNPCNum,
			iNPCNumType = iNPCNumType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iLifeType, str) || Check.CheckValue(iNPCID, str) || Check.CheckValue(iNPCIDType, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iLife, str) || Check.CheckValue(iPathID, str) || Check.CheckValue(iPathIDType, str) || Check.CheckValue(iNPCNum, str) || Check.CheckValue(iNPCNumType, str))
		{
			return true;
		}
		return false;
	}
}
