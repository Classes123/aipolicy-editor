using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_CLEAR_TOWER_TASK_IN_REGION
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_CLEAR_TOWER_TASK_IN_REGION");
	}

	public static O_CLEAR_TOWER_TASK_IN_REGION Read(BinaryReader br)
	{
		O_CLEAR_TOWER_TASK_IN_REGION o_CLEAR_TOWER_TASK_IN_REGION = new O_CLEAR_TOWER_TASK_IN_REGION();
		o_CLEAR_TOWER_TASK_IN_REGION.zvMin.Read(br);
		o_CLEAR_TOWER_TASK_IN_REGION.zvMax.Read(br);
		return o_CLEAR_TOWER_TASK_IN_REGION;
	}

	public static void Write(BinaryWriter bw, O_CLEAR_TOWER_TASK_IN_REGION param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_CLEAR_TOWER_TASK_IN_REGION
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
