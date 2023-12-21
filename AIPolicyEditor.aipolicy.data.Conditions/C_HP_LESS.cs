using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_HP_LESS
{
	public float fPercent { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_HP_LESS");
	}

	public static C_HP_LESS Read(BinaryReader br)
	{
		return new C_HP_LESS
		{
			fPercent = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, C_HP_LESS param)
	{
		bw.Write(param.fPercent);
	}

	public object Copy()
	{
		return new C_HP_LESS
		{
			fPercent = fPercent
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(fPercent, str))
		{
			return true;
		}
		return false;
	}
}
