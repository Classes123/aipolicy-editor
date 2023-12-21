using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_HISTORY_STAGE
{
	public int iID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_HISTORY_STAGE");
	}

	public static C_HISTORY_STAGE Read(BinaryReader br)
	{
		return new C_HISTORY_STAGE
		{
			iID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_HISTORY_STAGE param)
	{
		bw.Write(param.iID);
	}

	public object Copy()
	{
		return new C_HISTORY_STAGE
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
