using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_STOP_TRIGGER
{
	public int uID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_STOP_TRIGGER");
	}

	public static O_STOP_TRIGGER Read(BinaryReader br)
	{
		return new O_STOP_TRIGGER
		{
			uID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_STOP_TRIGGER param)
	{
		bw.Write(param.uID);
	}

	public object Copy()
	{
		return new O_STOP_TRIGGER
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
