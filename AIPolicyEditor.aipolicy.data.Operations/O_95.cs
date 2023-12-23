using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_95
{
    public bool unk1 { get; set; }
    
	public override string ToString()
	{
		return string.Format("{0}", "O_95");
	}

	public static O_95 Read(BinaryReader br)
	{
		return new O_95 //1 byte
		{
            unk1 = br.ReadBoolean(),
		};
	}

	public static void Write(BinaryWriter bw, O_95 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new O_95
		{
			unk1 = unk1,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str))
		{
			return true;
		}

		return false;
	}
}
