using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM
{
	public float fRadiusValue { get; set; }

	public CTriggerData.enumPolicyVarType uRadiusType { get; set; }

	public int iTargetID { get; set; }

	public CTriggerData.enumPolicyVarType uTargetType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM");
	}

	public static O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM Read(BinaryReader br)
	{
		return new O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM
		{
			fRadiusValue = br.ReadSingle(),
			uRadiusType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iTargetID = br.ReadInt32(),
			uTargetType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM param)
	{
		bw.Write(param.fRadiusValue);
		bw.Write((int)param.uRadiusType);
		bw.Write(param.iTargetID);
		bw.Write((int)param.uTargetType);
	}

	public object Copy()
	{
		return new O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM
		{
			fRadiusValue = fRadiusValue,
			uRadiusType = uRadiusType,
			iTargetID = iTargetID,
			uTargetType = uTargetType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(fRadiusValue, str) || Check.CheckValue(uRadiusType, str) || Check.CheckValue(iTargetID, str) || Check.CheckValue(uTargetType, str))
		{
			return true;
		}
		return false;
	}
}
