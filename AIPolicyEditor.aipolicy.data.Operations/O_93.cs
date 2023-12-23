using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_93
{
    public int unk1 { get; set; } //possibly variable
    public int unk2 { get; set; }
    public int unk3 { get; set; }
    public int unk4 { get; set; }
    public int unk5 { get; set; }
    public int unk6 { get; set; }
    public int unk7 { get; set; }
    public int unk8 { get; set; }
    public int unk9 { get; set; }
    public int unk10 { get; set; }
    
	public override string ToString()
	{
		return string.Format("{0}", "O_93");
	}

	public static O_93 Read(BinaryReader br)
	{
		return new O_93 //40 bytes
		{
            unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            unk3 = br.ReadInt32(),
            unk4 = br.ReadInt32(),
            unk5 = br.ReadInt32(),
            unk6 = br.ReadInt32(),
            unk7 = br.ReadInt32(),
            unk8 = br.ReadInt32(),
            unk9 = br.ReadInt32(),
            unk10 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_93 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.unk2);
        bw.Write(param.unk3);
        bw.Write(param.unk4);
        bw.Write(param.unk5);
        bw.Write(param.unk6);
        bw.Write(param.unk7);
        bw.Write(param.unk8);
        bw.Write(param.unk9);
        bw.Write(param.unk10);
	}

	public object Copy()
	{
		return new O_93
		{
			unk1 = unk1,
            unk2 = unk2,
            unk3 = unk3,
            unk4 = unk4,
            unk5 = unk5,
            unk6 = unk6,
            unk7 = unk7,
            unk8 = unk8,
            unk9 = unk9,
            unk10 = unk10,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) 
            || Check.CheckValue(unk2, str) 
            || Check.CheckValue(unk3, str)
            || Check.CheckValue(unk4, str)
            || Check.CheckValue(unk5, str)
            || Check.CheckValue(unk6, str)
            || Check.CheckValue(unk7, str)
            || Check.CheckValue(unk8, str)
            || Check.CheckValue(unk9, str)
            || Check.CheckValue(unk10, str))
		{
			return true;
		}

		return false;
	}
}
