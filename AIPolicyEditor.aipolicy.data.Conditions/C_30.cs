using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_30
{
	public int WDay { get; set; }

	public int Hour { get; set; }

	public int Minute { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_30");
	}

	public static C_30 Read(BinaryReader br)
	{
		return new C_30
		{
			WDay = br.ReadInt32(),
			Hour = br.ReadInt32(),
			Minute = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_30 param)
	{
		bw.Write(param.WDay);
		bw.Write(param.Hour);
		bw.Write(param.Minute);
	}

	public object Copy()
	{
		return new C_30
		{
			WDay = WDay,
			Hour = Hour,
			Minute = Minute
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(WDay, str) || Check.CheckValue(Hour, str) || Check.CheckValue(Minute, str))
		{
			return true;
		}
		return false;
	}
}
