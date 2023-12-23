using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_85
{
	public int unk1 { get; set; }
    public int unk2 { get; set; }
    public int unk3 { get; set; }
    public int unk4 { get; set; }
    public int iMobId { get; set; }
    public int unk5 { get; set; }
    public int unk6 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_85");
	}

	public static O_85 Read(BinaryReader br)
	{
		return new O_85 //28 bytes
		{
			unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            unk3 = br.ReadInt32(),
            unk4 = br.ReadInt32(),
            iMobId = br.ReadInt32(),
            unk5 = br.ReadInt32(),
            unk6 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_85 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.unk2);
        bw.Write(param.unk3);
        bw.Write(param.unk4);
        bw.Write(param.iMobId);
        bw.Write(param.unk5);
        bw.Write(param.unk6);
	}

	public object Copy()
	{
		return new O_85
		{
			unk1 = unk1,
            unk2 = unk2,
            unk3 = unk3,
            unk4 = unk4,
            iMobId = iMobId,
            unk5 = unk5,
            unk6 = unk6,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) 
            || Check.CheckValue(unk2, str) 
            || Check.CheckValue(unk3, str) 
            || Check.CheckValue(unk4, str) 
            || Check.CheckValue(iMobId, str) 
            || Check.CheckValue(unk5, str) 
            || Check.CheckValue(unk6, str))
		{
			return true;
		}

		return false;
	}
}
