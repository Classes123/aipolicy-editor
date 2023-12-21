using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_48
{
	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_48");
	}

	public static O_48 Read(BinaryReader br)
	{
		return new O_48
		{
			unk1 = br.ReadInt32(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_48 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
	}

	public object Copy()
	{
		return new O_48
		{
			unk1 = unk1,
			unk1Type = unk1Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk1Type, str))
		{
			return true;
		}
		return false;
	}
}
