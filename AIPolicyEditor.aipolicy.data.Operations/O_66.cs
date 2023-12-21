using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_66
{
	public int unk1 { get; set; }

	public int unk2 { get; set; }

	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_66");
	}

	public static O_66 Read(BinaryReader br)
	{
		O_66 o_ = new O_66();
		o_.unk1 = br.ReadInt32();
		o_.unk2 = br.ReadInt32();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		return o_;
	}

	public static void Write(BinaryWriter bw, O_66 param)
	{
		bw.Write(param.unk1);
		bw.Write(param.unk2);
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_66
		{
			unk1 = unk1,
			unk2 = unk2,
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(unk1, str) || Check.CheckValue(unk2, str) || zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
