using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Targets;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class T_14
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "T_14");
	}

	public static T_14 Read(BinaryReader br)
	{
		return new T_14
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, T_14 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new T_14
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
