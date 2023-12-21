using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_45
{
	public int iWorldID { get; set; }

	public int unk2 { get; set; }

	public CTriggerData.enumPolicyVarType unk2Type { get; set; }

	public int unk3 { get; set; }

	public CTriggerData.enumPolicyVarType unk3Type { get; set; }

	public int unk4 { get; set; }

	public CTriggerData.enumPolicyVarType unk4Type { get; set; }

	public int unk5 { get; set; }

	public CTriggerData.enumPolicyVarType unk5Type { get; set; }

	public int unk6 { get; set; }

	public CTriggerData.enumPolicyVarType unk6Type { get; set; }

	public int unk7 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_45");
	}

	public static O_45 Read(BinaryReader br)
	{
		return new O_45
		{
			iWorldID = br.ReadInt32(),
			unk2 = br.ReadInt32(),
			unk2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk3 = br.ReadInt32(),
			unk3Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk4 = br.ReadInt32(),
			unk4Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk5 = br.ReadInt32(),
			unk5Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk6 = br.ReadInt32(),
			unk6Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk7 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_45 param)
	{
		bw.Write(param.iWorldID);
		bw.Write(param.unk2);
		bw.Write((int)param.unk2Type);
		bw.Write(param.unk3);
		bw.Write((int)param.unk3Type);
		bw.Write(param.unk4);
		bw.Write((int)param.unk4Type);
		bw.Write(param.unk5);
		bw.Write((int)param.unk5Type);
		bw.Write(param.unk6);
		bw.Write((int)param.unk6Type);
		bw.Write(param.unk7);
	}

	public object Copy()
	{
		return new O_45
		{
			iWorldID = iWorldID,
			unk2 = unk2,
			unk2Type = unk2Type,
			unk3 = unk3,
			unk3Type = unk3Type,
			unk4 = unk4,
			unk4Type = unk4Type,
			unk5 = unk5,
			unk5Type = unk5Type,
			unk6 = unk6,
			unk6Type = unk6Type,
			unk7 = unk7
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iWorldID, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk2Type, str) || Check.CheckValue(unk3, str) || Check.CheckValue(unk3Type, str) || Check.CheckValue(unk4, str) || Check.CheckValue(unk4Type, str) || Check.CheckValue(unk5, str) || Check.CheckValue(unk5Type, str) || Check.CheckValue(unk6, str) || Check.CheckValue(unk6Type, str) || Check.CheckValue(unk7, str))
		{
			return true;
		}
		return false;
	}
}
