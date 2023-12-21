using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_DELIVER_RANDOM_TASK_IN_REGION
{
	public int uID { get; set; }

	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_DELIVER_RANDOM_TASK_IN_REGION");
	}

	public static O_DELIVER_RANDOM_TASK_IN_REGION Read(BinaryReader br)
	{
		O_DELIVER_RANDOM_TASK_IN_REGION o_DELIVER_RANDOM_TASK_IN_REGION = new O_DELIVER_RANDOM_TASK_IN_REGION();
		o_DELIVER_RANDOM_TASK_IN_REGION.uID = br.ReadInt32();
		o_DELIVER_RANDOM_TASK_IN_REGION.zvMin.Read(br);
		o_DELIVER_RANDOM_TASK_IN_REGION.zvMax.Read(br);
		return o_DELIVER_RANDOM_TASK_IN_REGION;
	}

	public static void Write(BinaryWriter bw, O_DELIVER_RANDOM_TASK_IN_REGION param)
	{
		bw.Write(param.uID);
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_DELIVER_RANDOM_TASK_IN_REGION
		{
			uID = uID,
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
