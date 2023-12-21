using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_42
{
	public float fRadiusValue { get; set; }

	public CTriggerData.enumPolicyVarType uRadiusType { get; set; }

	public int iTargetID { get; set; }

	public CTriggerData.enumPolicyVarType uTargetType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_42");
	}

	public static O_42 Read(BinaryReader br)
	{
		return new O_42
		{
			fRadiusValue = br.ReadSingle(),
			uRadiusType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iTargetID = br.ReadInt32(),
			uTargetType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_42 param)
	{
		bw.Write(param.fRadiusValue);
		bw.Write((int)param.uRadiusType);
		bw.Write(param.iTargetID);
		bw.Write((int)param.uTargetType);
	}

	public object Copy()
	{
		return new O_42
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
