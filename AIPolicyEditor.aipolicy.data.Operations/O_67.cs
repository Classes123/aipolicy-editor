using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_67
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public int uSkill { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_67");
	}

	public static O_67 Read(BinaryReader br)
	{
		O_67 o_ = new O_67();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		o_.uSkill = br.ReadInt32();
		return o_;
	}

	public static void Write(BinaryWriter bw, O_67 param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
		bw.Write(param.uSkill);
	}

	public object Copy()
	{
		return new O_67
		{
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT),
			uSkill = uSkill
		};
	}

	public bool Search(string str)
	{
		if (zvMin.Search(str) || zvMax.Search(str) || Check.CheckValue(uSkill, str))
		{
			return true;
		}
		return false;
	}
}
