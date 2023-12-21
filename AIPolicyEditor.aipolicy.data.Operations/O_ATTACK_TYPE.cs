using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_ATTACK_TYPE
{
	public int uType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_ATTACK_TYPE");
	}

	public static O_ATTACK_TYPE Read(BinaryReader br)
	{
		return new O_ATTACK_TYPE
		{
			uType = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_ATTACK_TYPE param)
	{
		bw.Write(param.uType);
	}

	public object Copy()
	{
		return new O_ATTACK_TYPE
		{
			uType = uType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uType, str))
		{
			return true;
		}
		return false;
	}
}
