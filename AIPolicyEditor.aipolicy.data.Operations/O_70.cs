using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_70
{
	public float fRadius { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_70");
	}

	public static O_70 Read(BinaryReader br)
	{
		return new O_70
		{
			fRadius = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, O_70 param)
	{
		bw.Write(param.fRadius);
	}

	public object Copy()
	{
		return new O_70
		{
			fRadius = fRadius
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(fRadius, str))
		{
			return true;
		}
		return false;
	}
}
