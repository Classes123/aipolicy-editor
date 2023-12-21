using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Targets;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class T_18
{
	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public int unk2 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "T_18");
	}

	public static T_18 Read(BinaryReader br)
	{
		return new T_18
		{
			unk1 = br.ReadInt32(),
			unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			unk2 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, T_18 param)
	{
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
		bw.Write(param.unk2);
	}

	public object Copy()
	{
		return new T_18
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
