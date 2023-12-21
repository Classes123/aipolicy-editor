using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_60
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_60");
	}

	public static O_60 Read(BinaryReader br)
	{
		return new O_60
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_60 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new O_60
		{
			unk1 = unk1
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
