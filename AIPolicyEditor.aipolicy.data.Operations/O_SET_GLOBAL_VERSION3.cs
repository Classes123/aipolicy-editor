using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SET_GLOBAL_VERSION3
{
	public int iID { get; set; }

	public int iValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SET_GLOBAL");
	}

	public static O_SET_GLOBAL_VERSION3 Read(BinaryReader br)
	{
		return new O_SET_GLOBAL_VERSION3
		{
			iID = br.ReadInt32(),
			iValue = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_SET_GLOBAL_VERSION3 param)
	{
		bw.Write(param.iID);
		bw.Write(param.iValue);
	}

	public object Copy()
	{
		return new O_SET_GLOBAL_VERSION3
		{
			iID = iID,
			iValue = iValue
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iID, str) || Check.CheckValue(iValue, str))
		{
			return true;
		}
		return false;
	}
}
