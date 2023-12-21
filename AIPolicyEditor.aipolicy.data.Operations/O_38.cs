using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_38
{
	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public int unk2 { get; set; }

	public CTriggerData.enumPolicyVarType unk2Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_38");
	}

	public static O_38 Read(BinaryReader br)
	{
		return new O_38
		{
			unk1 = br.ReadInt32(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk2 = br.ReadInt32(),
			unk2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_38 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
		bw.Write(param.unk2);
		bw.Write((int)param.unk2Type);
	}

	public object Copy()
	{
		return new O_38
		{
			unk1 = unk1,
			unk1Type = unk1Type,
			unk2 = unk2,
			unk2Type = unk2Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk1Type, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk2Type, str))
		{
			return true;
		}
		return false;
	}
}
