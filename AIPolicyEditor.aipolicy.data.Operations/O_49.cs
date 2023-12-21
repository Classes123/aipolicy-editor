using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_49
{
	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public int unk2 { get; set; }

	public CTriggerData.enumPolicyVarType unk2Type { get; set; }

	public int unk3 { get; set; }

	public CTriggerData.enumPolicyVarType unk3Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_49");
	}

	public static O_49 Read(BinaryReader br)
	{
		return new O_49
		{
			unk1 = br.ReadInt32(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk2 = br.ReadInt32(),
			unk2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk3 = br.ReadInt32(),
			unk3Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_49 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
		bw.Write(param.unk2);
		bw.Write((int)param.unk2Type);
		bw.Write(param.unk3);
		bw.Write((int)param.unk3Type);
	}

	public object Copy()
	{
		return new O_49
		{
			unk1 = unk1,
			unk1Type = unk1Type,
			unk2 = unk2,
			unk2Type = unk2Type,
			unk3 = unk3,
			unk3Type = unk3Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk1Type, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk2Type, str) || Check.CheckValue(unk3, str) || Check.CheckValue(unk3Type, str))
		{
			return true;
		}
		return false;
	}
}
