using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_39
{
	public int unk1 { get; set; }

	public int unk2 { get; set; }

	public int unk3 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_39");
	}

	public static C_39 Read(BinaryReader br)
	{
		return new C_39
		{
			unk1 = br.ReadInt32(),
			unk2 = br.ReadInt32(),
			unk3 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_39 param)
	{
		bw.Write(param.unk1);
		bw.Write(param.unk2);
		bw.Write(param.unk3);
	}

	public object Copy()
	{
		return new C_39
		{
			unk1 = unk1,
			unk2 = unk2,
			unk3 = unk3
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk3, str))
		{
			return true;
		}
		return false;
	}
}
