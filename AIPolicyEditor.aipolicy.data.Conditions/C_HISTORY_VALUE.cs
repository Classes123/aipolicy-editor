using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_HISTORY_VALUE
{
	public int iValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_HISTORY_VALUE");
	}

	public static C_HISTORY_VALUE Read(BinaryReader br)
	{
		return new C_HISTORY_VALUE
		{
			iValue = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_HISTORY_VALUE param)
	{
		bw.Write(param.iValue);
	}

	public object Copy()
	{
		return new C_HISTORY_VALUE
		{
			iValue = iValue
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iValue, str))
		{
			return true;
		}
		return false;
	}
}
