using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_44
{
	public int iWorldID { get; set; }

	public int unk2 { get; set; }

	public CTriggerData.enumPolicyVarType unk2Type { get; set; }

	public int unk3 { get; set; }

	public CTriggerData.enumPolicyVarType unk3Type { get; set; }

	public int unk4 { get; set; }

	public CTriggerData.enumPolicyVarType unk4Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_44");
	}

	public static O_44 Read(BinaryReader br)
	{
		return new O_44
		{
			iWorldID = br.ReadInt32(),
			unk2 = br.ReadInt32(),
			unk2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk3 = br.ReadInt32(),
			unk3Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk4 = br.ReadInt32(),
			unk4Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_44 param)
	{
		bw.Write(param.iWorldID);
		bw.Write(param.unk2);
		bw.Write((int)param.unk2Type);
		bw.Write(param.unk3);
		bw.Write((int)param.unk3Type);
		bw.Write(param.unk4);
		bw.Write((int)param.unk4Type);
	}

	public object Copy()
	{
		return new O_44
		{
			iWorldID = iWorldID,
			unk2 = unk2,
			unk2Type = unk2Type,
			unk3 = unk3,
			unk3Type = unk3Type,
			unk4 = unk4,
			unk4Type = unk4Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iWorldID, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk2Type, str) || Check.CheckValue(unk3, str) || Check.CheckValue(unk3Type, str) || Check.CheckValue(unk4, str) || Check.CheckValue(unk4Type, str))
		{
			return true;
		}
		return false;
	}
}
