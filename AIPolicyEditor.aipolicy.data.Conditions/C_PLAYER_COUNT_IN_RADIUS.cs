using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_PLAYER_COUNT_IN_RADIUS
{
	public float fRadius { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_PLAYER_COUNT_IN_RADIUS");
	}

	public static C_PLAYER_COUNT_IN_RADIUS Read(BinaryReader br)
	{
		return new C_PLAYER_COUNT_IN_RADIUS
		{
			fRadius = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, C_PLAYER_COUNT_IN_RADIUS param)
	{
		bw.Write(param.fRadius);
	}

	public object Copy()
	{
		return new C_PLAYER_COUNT_IN_RADIUS
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
