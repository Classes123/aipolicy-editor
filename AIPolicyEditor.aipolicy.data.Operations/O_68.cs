using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_68
{
	public float unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public float unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_68");
	}

	public static O_68 Read(BinaryReader br)
	{
		return new O_68
		{
			unk1 = br.ReadSingle(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk2 = br.ReadSingle()
		};
	}

	public static void Write(BinaryWriter bw, O_68 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
		bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new O_68
		{
			unk1 = unk1,
			unk1Type = unk1Type,
			unk2 = unk2
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk1Type, str) || Check.CheckValue(unk2, str))
		{
			return true;
		}
		return false;
	}
}
