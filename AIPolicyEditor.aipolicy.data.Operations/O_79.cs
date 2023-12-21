using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_79
{
	public int iTargetID { get; set; }

	public CTriggerData.enumPolicyVarType uTargetType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_79");
	}

	public static O_79 Read(BinaryReader br)
	{
		return new O_79
		{
			iTargetID = br.ReadInt32(),
			uTargetType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_79 param)
	{
		bw.Write(param.iTargetID);
		bw.Write((int)param.uTargetType);
	}

	public object Copy()
	{
		return new O_79
		{
			iTargetID = iTargetID,
			uTargetType = uTargetType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iTargetID, str) || Check.CheckValue(uTargetType, str))
		{
			return true;
		}
		return false;
	}
}
