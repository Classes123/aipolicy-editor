using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SET_HISTORY
{
	private byte[] bytes = new byte[3];

	public int iID { get; set; }

	public int iValue { get; set; }

	public bool bIsHistoryValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SET_HISTORY");
	}

	public static O_SET_HISTORY Read(BinaryReader br)
	{
		return new O_SET_HISTORY
		{
			iID = br.ReadInt32(),
			iValue = br.ReadInt32(),
			bIsHistoryValue = br.ReadBoolean(),
			bytes = br.ReadBytes(3)
		};
	}

	public static void Write(BinaryWriter bw, O_SET_HISTORY param)
	{
		bw.Write(param.iID);
		bw.Write(param.iValue);
		bw.Write(param.bIsHistoryValue);
		bw.Write(param.bytes);
	}

	public object Copy()
	{
		return new O_SET_HISTORY
		{
			iID = iID,
			iValue = iValue,
			bIsHistoryValue = bIsHistoryValue
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iID, str) || Check.CheckValue(iValue, str) || Check.CheckValue(bIsHistoryValue, str))
		{
			return true;
		}
		return false;
	}
}
