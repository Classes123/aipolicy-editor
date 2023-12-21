using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_CONSTANT
{
	public int iValue { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_CONSTANT");
	}

	public static C_CONSTANT Read(BinaryReader br)
	{
		return new C_CONSTANT
		{
			iValue = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_CONSTANT param)
	{
		bw.Write(param.iValue);
	}

	public object Copy()
	{
		return new C_CONSTANT
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
