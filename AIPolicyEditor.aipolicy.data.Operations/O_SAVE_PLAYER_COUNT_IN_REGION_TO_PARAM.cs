using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public int iTargetID { get; set; }

	public CTriggerData.enumPolicyVarType uTargetType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM");
	}

	public static O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM Read(BinaryReader br)
	{
		O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM = new O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM();
		o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.zvMin.Read(br);
		o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.zvMax.Read(br);
		o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.iTargetID = br.ReadInt32();
		o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.uTargetType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		return o_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM;
	}

	public static void Write(BinaryWriter bw, O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
		bw.Write(param.iTargetID);
		bw.Write((int)param.uTargetType);
	}

	public object Copy()
	{
		return new O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM
		{
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT),
			iTargetID = iTargetID,
			uTargetType = uTargetType
		};
	}

	public bool Search(string str)
	{
		if (zvMin.Search(str) || zvMax.Search(str) || Check.CheckValue(iTargetID, str) || Check.CheckValue(uTargetType, str))
		{
			return true;
		}
		return false;
	}
}
