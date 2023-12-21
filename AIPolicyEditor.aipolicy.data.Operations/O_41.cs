using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_41
{
	public int iRadiusValue { get; set; }

	public CTriggerData.enumPolicyVarType uRadiusType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_41");
	}

	public static O_41 Read(BinaryReader br)
	{
		return new O_41
		{
			iRadiusValue = br.ReadInt32(),
			uRadiusType = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_41 param)
	{
		bw.Write(param.iRadiusValue);
		bw.Write((int)param.uRadiusType);
	}

	public object Copy()
	{
		return new O_41
		{
			iRadiusValue = iRadiusValue,
			uRadiusType = uRadiusType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iRadiusValue, str) || Check.CheckValue(uRadiusType, str))
		{
			return true;
		}
		return false;
	}
}
