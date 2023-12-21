using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SET_GLOBAL
{
	private byte[] bytes = new byte[3];

	public int iID { get; set; }

	public int iValue { get; set; }

	public bool bIsValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SET_GLOBAL");
	}

	public static O_SET_GLOBAL Read(BinaryReader br)
	{
		return new O_SET_GLOBAL
		{
			iID = br.ReadInt32(),
			iValue = br.ReadInt32(),
			bIsValue = br.ReadBoolean(),
			bytes = br.ReadBytes(3)
		};
	}

	public static void Write(BinaryWriter bw, O_SET_GLOBAL param)
	{
		bw.Write(param.iID);
		bw.Write(param.iValue);
		bw.Write(param.bIsValue);
		bw.Write(param.bytes);
	}

	public object Copy()
	{
		return new O_SET_GLOBAL
		{
			iID = iID,
			iValue = iValue,
			bIsValue = bIsValue
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iID, str) || Check.CheckValue(iValue, str) || Check.CheckValue(bIsValue, str))
		{
			return true;
		}
		return false;
	}
}
