using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_REACH_END_2
{
	public int iPathID { get; set; }

	public CTriggerData.enumPolicyVarType iPathIDType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_REACH_END_2");
	}

	public static C_REACH_END_2 Read(BinaryReader br)
	{
		return new C_REACH_END_2
		{
			iPathID = br.ReadInt32(),
			iPathIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_REACH_END_2 param)
	{
		bw.Write(param.iPathID);
		bw.Write((int)param.iPathIDType);
	}

	public object Copy()
	{
		return new C_REACH_END_2
		{
			iPathID = iPathID,
			iPathIDType = iPathIDType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iPathID, str) || Check.CheckValue(iPathIDType, str))
		{
			return true;
		}
		return false;
	}
}
