using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_97
{
	public override string ToString()
	{
		return string.Format("{0}", "O_97");
	}

	public static O_97 Read(BinaryReader br)
	{
		return new O_97 //0 bytes
		{
		};
	}

	public static void Write(BinaryWriter bw, O_97 param)
	{
	}

	public object Copy()
	{
		return new O_97
		{
		};
	}

	public bool Search(string str)
	{
		return false;
	}
}
