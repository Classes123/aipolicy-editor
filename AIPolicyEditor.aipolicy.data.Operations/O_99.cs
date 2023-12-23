using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_99
{

    public int unk1 { get; set; }
    public int iGlobalVar1 { get; set; }
    public int iGlobalVar2 { get; set; }
    public int iGlobalVar3 { get; set; }
    public int iGlobalVar4 { get; set; }
    public int iGlobalVar5 { get; set; }
    public int iGlobalVar6 { get; set; }
    public int unk2 { get; set; }
    public int unk3 { get; set; }
    public int unk4 { get; set; }
    public int unk5 { get; set; }
    public int unk6 { get; set; }
    public int unk7 { get; set; }
    public int unk8 { get; set; }
    public int unk9 { get; set; }
    public int unk10 { get; set; }
    public int unk11 { get; set; }
    public int unk12 { get; set; }
    public int iGlobalVar7 { get; set; }
    public int unk13 { get; set; }
    
	public override string ToString()
	{
		return string.Format("{0}", "O_99");
	}

	public static O_99 Read(BinaryReader br)
	{
		return new O_99 //80 bytes
		{
            unk1 = br.ReadInt32(),
            iGlobalVar1 = br.ReadInt32(),
            iGlobalVar2 = br.ReadInt32(),
            iGlobalVar3 = br.ReadInt32(),
            iGlobalVar4 = br.ReadInt32(),
            iGlobalVar5 = br.ReadInt32(),
            iGlobalVar6 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            unk3 = br.ReadInt32(),
            unk4 = br.ReadInt32(),
            unk5 = br.ReadInt32(),
            unk6 = br.ReadInt32(),
            unk7 = br.ReadInt32(),
            unk8 = br.ReadInt32(),
            unk9 = br.ReadInt32(),
            unk10 = br.ReadInt32(),
            unk11 = br.ReadInt32(),
            unk12 = br.ReadInt32(),
            iGlobalVar7 = br.ReadInt32(),
            unk13 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_99 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.iGlobalVar1);
        bw.Write(param.iGlobalVar2);
        bw.Write(param.iGlobalVar3);
        bw.Write(param.iGlobalVar4);
        bw.Write(param.iGlobalVar5);
        bw.Write(param.iGlobalVar6);
        bw.Write(param.unk2);
        bw.Write(param.unk3);
        bw.Write(param.unk4);
        bw.Write(param.unk5);
        bw.Write(param.unk6);
        bw.Write(param.unk7);
        bw.Write(param.unk8);
        bw.Write(param.unk9);
        bw.Write(param.unk10);
        bw.Write(param.unk11);
        bw.Write(param.unk12);
        bw.Write(param.iGlobalVar7);
        bw.Write(param.unk13);
	}

	public object Copy()
	{
		return new O_99
		{
			unk1 = unk1,
            iGlobalVar1 = iGlobalVar1,
            iGlobalVar2 = iGlobalVar2,
            iGlobalVar3 = iGlobalVar3,
            iGlobalVar4 = iGlobalVar4,
            iGlobalVar5 = iGlobalVar5,
            iGlobalVar6 = iGlobalVar6,
            unk2 = unk2,
            unk3 = unk3,
            unk4 = unk4,
            unk5 = unk5,
            unk6 = unk6,
            unk7 = unk7,
            unk8 = unk8,
            unk9 = unk9,
            unk10 = unk10,
            unk11 = unk11,
            unk12 = unk12,
            iGlobalVar7 = iGlobalVar7,
            unk13 = unk13,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) 
            || Check.CheckValue(iGlobalVar1, str) 
            || Check.CheckValue(iGlobalVar2, str) 
            || Check.CheckValue(iGlobalVar3, str) 
            || Check.CheckValue(iGlobalVar4, str) 
            || Check.CheckValue(iGlobalVar5, str) 
            || Check.CheckValue(iGlobalVar6, str) 
            || Check.CheckValue(unk2, str) 
            || Check.CheckValue(unk3, str)
            || Check.CheckValue(unk4, str)
            || Check.CheckValue(unk5, str)
            || Check.CheckValue(unk6, str)
            || Check.CheckValue(unk7, str)
            || Check.CheckValue(unk8, str)
            || Check.CheckValue(unk9, str)
            || Check.CheckValue(unk10, str)
            || Check.CheckValue(unk11, str)
            || Check.CheckValue(unk12, str)
            || Check.CheckValue(iGlobalVar7, str) 
            || Check.CheckValue(unk13, str))
		{
			return true;
		}

		return false;
	}
}
