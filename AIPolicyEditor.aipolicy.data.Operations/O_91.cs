using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_91
{
    public int iGlobalVar1 { get; set; }
    public int unk1 { get; set; }
    public int iGlobalVar2 { get; set; }
    public int unk2 { get; set; }
    public int iGlobalVar3 { get; set; }
    public int unk3 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_91");
	}

	public static O_91 Read(BinaryReader br)
	{
		return new O_91 //24 bytes
		{
            iGlobalVar1 = br.ReadInt32(),
            unk1 = br.ReadInt32(),
            iGlobalVar2 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            iGlobalVar3 = br.ReadInt32(),
            unk3 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_91 param)
	{
        bw.Write(param.iGlobalVar1);
		bw.Write(param.unk1);
        bw.Write(param.iGlobalVar2);
		bw.Write(param.unk2);
        bw.Write(param.iGlobalVar3);
		bw.Write(param.unk3);
	}

	public object Copy()
	{
		return new O_91
		{
            iGlobalVar1 = iGlobalVar1,
			unk1 = unk1,
            iGlobalVar2 = iGlobalVar2,
			unk2 = unk2,
            iGlobalVar3 = iGlobalVar3,
			unk3 = unk3,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iGlobalVar1, str) 
            || Check.CheckValue(unk1, str) 
            || Check.CheckValue(iGlobalVar2, str)
            || Check.CheckValue(unk2, str)
            || Check.CheckValue(iGlobalVar3, str)
            || Check.CheckValue(unk3, str))
		{
			return true;
		}

		return false;
	}
}
