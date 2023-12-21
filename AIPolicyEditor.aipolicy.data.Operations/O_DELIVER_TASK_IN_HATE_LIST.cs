using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_DELIVER_TASK_IN_HATE_LIST
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public int iRange { get; set; }

	public int iPlayerNum { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_DELIVER_TASK_IN_HATE_LIST");
	}

	public static O_DELIVER_TASK_IN_HATE_LIST Read(BinaryReader br)
	{
		return new O_DELIVER_TASK_IN_HATE_LIST
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iRange = br.ReadInt32(),
			iPlayerNum = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_DELIVER_TASK_IN_HATE_LIST param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
		bw.Write(param.iRange);
		bw.Write(param.iPlayerNum);
	}

	public object Copy()
	{
		return new O_DELIVER_TASK_IN_HATE_LIST
		{
			uID = uID,
			uIDType = uIDType,
			iRange = iRange,
			iPlayerNum = iPlayerNum
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uIDType, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iPlayerNum, str))
		{
			return true;
		}
		return false;
	}
}
