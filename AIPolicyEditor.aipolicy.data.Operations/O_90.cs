using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_90
{
    public int unk1 { get; set; }
    public int unk2 { get; set; }
    public int iGlobalVar { get; set; }
    public int unk3 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_90");
	}

	public static O_90 Read(BinaryReader br)
	{
		return new O_90 //16 bytes
		{
            unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            iGlobalVar = br.ReadInt32(),
            unk3 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_90 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.unk2);
        bw.Write(param.iGlobalVar);
        bw.Write(param.unk3);
	}

	public object Copy()
	{
		return new O_90
		{
			unk1 = unk1,
            unk2 = unk2,
            iGlobalVar = iGlobalVar,
            unk3 = unk3,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) 
            || Check.CheckValue(unk2, str)
            || Check.CheckValue(iGlobalVar, str)
            || Check.CheckValue(unk3, str))
		{
			return true;
		}

		return false;
	}
}
