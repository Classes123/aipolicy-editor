using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_PLAYER_COUNT_IN_REGION
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "C_PLAYER_COUNT_IN_REGION");
	}

	public static C_PLAYER_COUNT_IN_REGION Read(BinaryReader br)
	{
		C_PLAYER_COUNT_IN_REGION c_PLAYER_COUNT_IN_REGION = new C_PLAYER_COUNT_IN_REGION();
		c_PLAYER_COUNT_IN_REGION.zvMin.Read(br);
		c_PLAYER_COUNT_IN_REGION.zvMax.Read(br);
		return c_PLAYER_COUNT_IN_REGION;
	}

	public static void Write(BinaryWriter bw, C_PLAYER_COUNT_IN_REGION param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new C_PLAYER_COUNT_IN_REGION
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
