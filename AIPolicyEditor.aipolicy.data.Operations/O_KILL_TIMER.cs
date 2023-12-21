using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_KILL_TIMER
{
	public int uID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_KILL_TIMER");
	}

	public static O_KILL_TIMER Read(BinaryReader br)
	{
		return new O_KILL_TIMER
		{
			uID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_KILL_TIMER param)
	{
		bw.Write(param.uID);
	}

	public object Copy()
	{
		return new O_KILL_TIMER
		{
			uID = uID
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str))
		{
			return true;
		}
		return false;
	}
}
