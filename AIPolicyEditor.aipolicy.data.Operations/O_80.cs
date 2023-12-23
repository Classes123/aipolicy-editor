using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_80
{
	public string unk1 { get; set; }
    public int iID { get; set; }
    public int unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_80");
	}

	public static O_80 Read(BinaryReader br)
	{
		return new O_80 //24 bytes
		{
			unk1 = br.ReadBytes(16).ByteArray_to_GbkString(),
            iID = br.ReadInt32(),
            unk2 = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_80 param)
	{
		bw.Write(param.unk1.GbkString_to_ByteArray(16));
        bw.Write(param.iID);
        bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new O_80
		{
			unk1 = unk1,
            iID = iID,
            unk2 = unk2,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(iID, str) || Check.CheckValue(unk2, str))
		{
			return true;
		}

		return false;
	}
}
