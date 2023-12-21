using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_58
{
	public float unk1 { get; set; }

	public int unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_58");
	}

	public static O_58 Read(BinaryReader br)
	{
		return new O_58
		{
			unk1 = br.ReadSingle(),
			unk2 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_58 param)
	{
		bw.Write(param.unk1);
		bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new O_58
		{
			unk1 = unk1,
			unk2 = unk2
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk2, str))
		{
			return true;
		}
		return false;
	}
}
