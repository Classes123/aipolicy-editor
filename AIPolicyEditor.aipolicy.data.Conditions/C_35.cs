using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_35
{
	public float fRadius { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_35");
	}

	public static C_35 Read(BinaryReader br)
	{
		return new C_35
		{
			fRadius = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, C_35 param)
	{
		bw.Write(param.fRadius);
	}

	public object Copy()
	{
		return new C_35
		{
			fRadius = fRadius
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(fRadius, str))
		{
			return true;
		}
		return false;
	}
}
