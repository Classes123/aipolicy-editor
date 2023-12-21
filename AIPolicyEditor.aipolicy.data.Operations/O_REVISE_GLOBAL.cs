using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_REVISE_GLOBAL
{
	public int iID { get; set; }

	public int iValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_REVISE_GLOBAL");
	}

	public static O_REVISE_GLOBAL Read(BinaryReader br)
	{
		return new O_REVISE_GLOBAL
		{
			iID = br.ReadInt32(),
			iValue = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_REVISE_GLOBAL param)
	{
		bw.Write(param.iID);
		bw.Write(param.iValue);
	}

	public object Copy()
	{
		return new O_REVISE_GLOBAL
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
