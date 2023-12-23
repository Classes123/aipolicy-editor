using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_101
{
    public int unk1 { get; set; }
    public int unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_101");
	}

	public static O_101 Read(BinaryReader br)
	{
		return new O_101 //8 bytes
		{
            unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_101 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new O_101
		{
			unk1 = unk1,
            unk2 = unk2,
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
