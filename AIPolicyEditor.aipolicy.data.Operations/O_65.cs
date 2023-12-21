using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_65
{
	private byte[] bytes = new byte[3];

	public bool unk1 { get; set; }

	public int unk2 { get; set; }

	public int unk3 { get; set; }

	public int unk4 { get; set; }

	public int unk5 { get; set; }

	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_65");
	}

	public static O_65 Read(BinaryReader br)
	{
		O_65 o_ = new O_65();
		o_.unk1 = br.ReadBoolean();
		o_.bytes = br.ReadBytes(3);
		o_.unk2 = br.ReadInt32();
		o_.unk3 = br.ReadInt32();
		o_.unk4 = br.ReadInt32();
		o_.unk5 = br.ReadInt32();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		return o_;
	}

	public static void Write(BinaryWriter bw, O_65 param)
	{
		bw.Write(param.unk1);
		bw.Write(param.bytes);
		bw.Write(param.unk2);
		bw.Write(param.unk3);
		bw.Write(param.unk4);
		bw.Write(param.unk5);
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_65
		{
			unk1 = unk1,
			unk2 = unk2,
			unk3 = unk3,
			unk4 = unk4,
			unk5 = unk5,
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk3, str) || Check.CheckValue(unk4, str) || Check.CheckValue(unk5, str) || zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
