using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_84
{
	public override string ToString()
	{
		return string.Format("{0}", "O_84");
	}

	public static O_84 Read(BinaryReader br)
	{
		return new O_84 //0 bytes
		{
		};
	}

	public static void Write(BinaryWriter bw, O_84 param)
	{
	}

	public object Copy()
	{
		return new O_84
		{
		};
	}

	public bool Search(string str)
	{
		return false;
	}
}
