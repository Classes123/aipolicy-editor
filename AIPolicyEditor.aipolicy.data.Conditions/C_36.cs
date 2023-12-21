using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_36
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "C_36");
	}

	public static C_36 Read(BinaryReader br)
	{
		C_36 c_ = new C_36();
		c_.zvMin.Read(br);
		c_.zvMax.Read(br);
		return c_;
	}

	public static void Write(BinaryWriter bw, C_36 param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new C_36
		{
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
