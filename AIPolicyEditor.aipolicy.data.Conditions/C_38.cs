using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_38
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_38");
	}

	public static C_38 Read(BinaryReader br)
	{
		return new C_38
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_38 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new C_38
		{
			unk1 = unk1
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str))
		{
			return true;
		}
		return false;
	}
}
