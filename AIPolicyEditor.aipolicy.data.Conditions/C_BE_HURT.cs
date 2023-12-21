using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_BE_HURT
{
	public int iHurtLow { get; set; }

	public int iHurtHigh { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "больший урон");
	}

	public static C_BE_HURT Read(BinaryReader br)
	{
		return new C_BE_HURT
		{
			iHurtLow = br.ReadInt32(),
			iHurtHigh = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_BE_HURT param)
	{
		bw.Write(param.iHurtLow);
		bw.Write(param.iHurtHigh);
	}

	public object Copy()
	{
		return new C_BE_HURT
		{
			iHurtLow = iHurtLow,
			iHurtHigh = iHurtHigh
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iHurtLow, str) || Check.CheckValue(iHurtHigh, str))
		{
			return true;
		}
		return false;
	}
}
