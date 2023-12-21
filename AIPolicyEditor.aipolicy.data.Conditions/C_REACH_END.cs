using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_REACH_END
{
	public int iPathID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_REACH_END");
	}

	public static C_REACH_END Read(BinaryReader br)
	{
		return new C_REACH_END
		{
			iPathID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_REACH_END param)
	{
		bw.Write(param.iPathID);
	}

	public object Copy()
	{
		return new C_REACH_END
		{
			iPathID = iPathID
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iPathID, str))
		{
			return true;
		}
		return false;
	}
}
