using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_43
{
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_43");
	}

	public static C_43 Read(BinaryReader br)
	{
		return new C_43 //4 bytes
		{
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_43 param)
	{
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new C_43
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
