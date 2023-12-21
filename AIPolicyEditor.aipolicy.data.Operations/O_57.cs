using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_57
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_57");
	}

	public static O_57 Read(BinaryReader br)
	{
		return new O_57
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_57 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new O_57
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
