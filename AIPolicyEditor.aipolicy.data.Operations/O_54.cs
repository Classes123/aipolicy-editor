using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_54
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public int uPeriod { get; set; }

	public CTriggerData.enumPolicyVarType uPeriodType { get; set; }

	public int uCounter { get; set; }

	public CTriggerData.enumPolicyVarType uCounterType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_54");
	}

	public static O_54 Read(BinaryReader br)
	{
		return new O_54
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			uPeriod = br.ReadInt32(),
			uPeriodType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			uCounter = br.ReadInt32(),
			uCounterType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_54 param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
		bw.Write(param.uPeriod);
		bw.Write((int)param.uPeriodType);
		bw.Write(param.uCounter);
		bw.Write((int)param.uCounterType);
	}

	public object Copy()
	{
		return new O_54
		{
			uID = uID,
			uIDType = uIDType,
			uPeriod = uPeriod,
			uPeriodType = uPeriodType,
			uCounter = uCounter,
			uCounterType = uCounterType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uIDType, str) || Check.CheckValue(uPeriod, str) || Check.CheckValue(uPeriodType, str) || Check.CheckValue(uCounter, str) || Check.CheckValue(uCounterType, str))
		{
			return true;
		}
		return false;
	}
}
