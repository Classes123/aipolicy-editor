using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_83
{
	public string sText { get; set; }
    public int iMobId { get; set; }
    public int iGlobalVar { get; set; }
    public int unk1 { get; set; }
    public int unk2 { get; set; }
    public int unk3 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_83");
	}

	public static O_83 Read(BinaryReader br)
	{
		return new O_83 //44 bytes
		{
            sText = br.ReadBytes(24).ByteArray_to_GbkString(),
            iMobId = br.ReadInt32(),
            iGlobalVar = br.ReadInt32(),
			unk1 = br.ReadInt32(),
            unk2 = br.ReadInt32(),
            unk3 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_83 param)
	{
        bw.Write(param.sText);
        bw.Write(param.iMobId);
        bw.Write(param.iGlobalVar);
		bw.Write(param.unk1);
        bw.Write(param.unk2);
        bw.Write(param.unk3);
	}

	public object Copy()
	{
		return new O_83
		{
            sText = sText,
            iMobId = iMobId,
            iGlobalVar = iGlobalVar,
			unk1 = unk1,
            unk2 = unk2,
            unk3 = unk3,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(sText, str)
            || Check.CheckValue(iMobId, str)
            || Check.CheckValue(iGlobalVar, str)
            || Check.CheckValue(unk1, str) 
            || Check.CheckValue(unk2, str) 
            || Check.CheckValue(unk3, str))
		{
			return true;
		}

		return false;
	}
}
