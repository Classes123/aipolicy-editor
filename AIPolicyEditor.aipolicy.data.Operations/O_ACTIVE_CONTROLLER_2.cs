using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_ACTIVE_CONTROLLER_2
{
	private byte[] bytes = new byte[3];

	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public bool bStop { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_ACTIVE_CONTROLLER_2");
	}

	public static O_ACTIVE_CONTROLLER_2 Read(BinaryReader br)
	{
		return new O_ACTIVE_CONTROLLER_2
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			bStop = br.ReadBoolean(),
			bytes = br.ReadBytes(3)
		};
	}

	public static void Write(BinaryWriter bw, O_ACTIVE_CONTROLLER_2 param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
		bw.Write(param.bStop);
		bw.Write(param.bytes);
	}

	public object Copy()
	{
		return new O_ACTIVE_CONTROLLER_2
		{
			uID = uID,
			uIDType = uIDType,
			bStop = bStop
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uIDType, str) || Check.CheckValue(bStop, str))
		{
			return true;
		}
		return false;
	}
}
