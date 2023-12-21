using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_40
{
	public float unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_40");
	}

	public static O_40 Read(BinaryReader br)
	{
		return new O_40
		{
			unk1 = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, O_40 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new O_40
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
