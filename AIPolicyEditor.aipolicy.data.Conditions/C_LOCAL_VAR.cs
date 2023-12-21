using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_LOCAL_VAR
{
	public int iID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_LOCAL_VAR");
	}

	public static C_LOCAL_VAR Read(BinaryReader br)
	{
		return new C_LOCAL_VAR
		{
			iID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_LOCAL_VAR param)
	{
		bw.Write(param.iID);
	}

	public object Copy()
	{
		return new C_LOCAL_VAR
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
