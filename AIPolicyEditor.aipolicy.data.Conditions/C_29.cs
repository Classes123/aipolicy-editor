using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_29
{
	public int Year { get; set; }

	public int Month { get; set; }

	public int Day { get; set; }

	public int Hour { get; set; }

	public int Minute { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_29");
	}

	public static C_29 Read(BinaryReader br)
	{
		return new C_29
		{
			Year = br.ReadInt32(),
			Month = br.ReadInt32(),
			Day = br.ReadInt32(),
			Hour = br.ReadInt32(),
			Minute = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_29 param)
	{
		bw.Write(param.Year);
		bw.Write(param.Month);
		bw.Write(param.Day);
		bw.Write(param.Hour);
		bw.Write(param.Minute);
	}

	public object Copy()
	{
		return new C_29
		{
			Year = Year,
			Month = Month,
			Day = Day,
			Hour = Hour,
			Minute = Minute
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(Year, str) || Check.CheckValue(Month, str) || Check.CheckValue(Day, str) || Check.CheckValue(Hour, str) || Check.CheckValue(Minute, str))
		{
			return true;
		}
		return false;
	}
}
