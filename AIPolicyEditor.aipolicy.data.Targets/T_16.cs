using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Targets;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class T_16
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "T_16");
	}

	public static T_16 Read(BinaryReader br)
	{
		return new T_16
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, T_16 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new T_16
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
