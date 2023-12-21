using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_DELIVER_TASK
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_DELIVER_TASK");
	}

	public static O_DELIVER_TASK Read(BinaryReader br)
	{
		return new O_DELIVER_TASK
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_DELIVER_TASK param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
	}

	public object Copy()
	{
		return new O_DELIVER_TASK
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
