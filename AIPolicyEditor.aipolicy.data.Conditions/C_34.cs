using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class C_34
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_34");
	}

	public static C_34 Read(BinaryReader br)
	{
		return new C_34
		{
			uID = br.ReadInt32(),
			uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_34 param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
	}

	public object Copy()
	{
		return new C_34
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
