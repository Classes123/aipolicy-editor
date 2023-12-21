using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_75
{
	public int uID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_75");
	}

	public static O_75 Read(BinaryReader br)
	{
		return new O_75
		{
			uID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_75 param)
	{
		bw.Write(param.uID);
	}

	public object Copy()
	{
		return new O_75
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
