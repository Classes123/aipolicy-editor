using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class POLICY_CONTROLLER_LIST
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "POLICY_CONTROLLER_LIST");
	}

	public static POLICY_CONTROLLER_LIST Read(BinaryReader br)
	{
		return new POLICY_CONTROLLER_LIST
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, POLICY_CONTROLLER_LIST param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
	}

	public POLICY_CONTROLLER_LIST Copy()
	{
		return new POLICY_CONTROLLER_LIST
		{
			uID = uID,
			uIDType = uIDType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uIDType, str))
		{
			return true;
		}
		return false;
	}
}
