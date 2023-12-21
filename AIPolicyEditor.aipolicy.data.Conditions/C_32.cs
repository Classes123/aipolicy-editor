using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_32
{
	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_32");
	}

	public static C_32 Read(BinaryReader br)
	{
		return new C_32
		{
			unk1 = br.ReadInt32(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_32 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
	}

	public object Copy()
	{
		return new C_32
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
