using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_HAS_FILTER
{
	public int iID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_HAS_FILTER");
	}

	public static C_HAS_FILTER Read(BinaryReader br)
	{
		return new C_HAS_FILTER
		{
			iID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_HAS_FILTER param)
	{
		bw.Write(param.iID);
	}

	public object Copy()
	{
		return new C_HAS_FILTER
		{
			iID = iID
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iID, str))
		{
			return true;
		}
		return false;
	}
}
