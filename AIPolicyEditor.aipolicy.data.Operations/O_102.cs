using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_102
{
    public int unk1 { get; set; }
    public int iGlobalVar { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_102");
	}

	public static O_102 Read(BinaryReader br)
	{
		return new O_102 //8 bytes
		{
            unk1 = br.ReadInt32(),
            iGlobalVar = br.ReadInt32(),
		};
	}

	public static void Write(BinaryWriter bw, O_102 param)
	{
		bw.Write(param.unk1);
        bw.Write(param.iGlobalVar);
	}

	public object Copy()
	{
		return new O_102
		{
			unk1 = unk1,
            iGlobalVar = iGlobalVar,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(iGlobalVar, str))
		{
			return true;
		}

		return false;
	}
}
