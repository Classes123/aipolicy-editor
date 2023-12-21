using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_CREATE_TIMER
{
	public int uID { get; set; }

	public int uPeriod { get; set; }

	public int uCounter { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_CREATE_TIMER");
	}

	public static O_CREATE_TIMER Read(BinaryReader br)
	{
		return new O_CREATE_TIMER
		{
			uID = br.ReadInt32(),
			uPeriod = br.ReadInt32(),
			uCounter = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_CREATE_TIMER param)
	{
		bw.Write(param.uID);
		bw.Write(param.uPeriod);
		bw.Write(param.uCounter);
	}

	public object Copy()
	{
		return new O_CREATE_TIMER
		{
			uID = uID,
			uPeriod = uPeriod,
			uCounter = uCounter
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uPeriod, str) || Check.CheckValue(uCounter, str))
		{
			return true;
		}
		return false;
	}
}
