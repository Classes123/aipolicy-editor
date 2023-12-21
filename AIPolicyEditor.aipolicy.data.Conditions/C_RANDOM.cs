using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_RANDOM
{
	public float fProbability { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_RANDOM");
	}

	public static C_RANDOM Read(BinaryReader br)
	{
		return new C_RANDOM
		{
			fProbability = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, C_RANDOM param)
	{
		bw.Write(param.fProbability);
	}

	public object Copy()
	{
		return new C_RANDOM
		{
			fProbability = fProbability
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(fProbability, str))
		{
			return true;
		}
		return false;
	}
}
