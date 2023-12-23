using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_86
{
	public int iMobId { get; set; }
    public int unk1 { get; set; }
    public int unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_86");
	}

	public static O_86 Read(BinaryReader br)
	{
		return new O_86 //12 bytes
		{
            iMobId = br.ReadInt32(),
            unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_86 param)
	{
        bw.Write(param.iMobId);
		bw.Write(param.unk1);
        bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new O_86
		{
            iMobId = iMobId,
			unk1 = unk1,
            unk2 = unk2,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iMobId, str) 
            || Check.CheckValue(unk1, str) 
            || Check.CheckValue(unk2, str))
		{
			return true;
		}

		return false;
	}
}
