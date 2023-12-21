using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_37
{
	public byte unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_37");
	}

	public static C_37 Read(BinaryReader br)
	{
		return new C_37
		{
			unk1 = br.ReadByte()
		};
	}

	public static void Write(BinaryWriter bw, C_37 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new C_37
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
