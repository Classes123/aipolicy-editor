using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_CALC_VAR
{
	public int iDst { get; set; }

	public CTriggerData.enumPolicyVarType iDstType { get; set; }

	public int iSrc1 { get; set; }

	public CTriggerData.enumPolicyVarType iSrc1Type { get; set; }

	public CTriggerData.enumPolicyOperatorType iOp { get; set; }

	public int iSrc2 { get; set; }

	public CTriggerData.enumPolicyVarType iSrc2Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_CALC_VAR");
	}

	public static O_CALC_VAR Read(BinaryReader br)
	{
		return new O_CALC_VAR
		{
			iDst = br.ReadInt32(),
			iDstType = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iSrc1 = br.ReadInt32(),
			iSrc1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32(),
			iOp = (CTriggerData.enumPolicyOperatorType)br.ReadInt32(),
			iSrc2 = br.ReadInt32(),
			iSrc2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_CALC_VAR param)
	{
		bw.Write(param.iDst);
		bw.Write((int)param.iDstType);
		bw.Write(param.iSrc1);
		bw.Write((int)param.iSrc1Type);
		bw.Write((int)param.iOp);
		bw.Write(param.iSrc2);
		bw.Write((int)param.iSrc2Type);
	}

	public object Copy()
	{
		return new O_CALC_VAR
		{
			iDst = iDst,
			iDstType = iDstType,
			iSrc1 = iSrc1,
			iSrc1Type = iSrc1Type,
			iOp = iOp,
			iSrc2 = iSrc2,
			iSrc2Type = iSrc2Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iDst, str) || Check.CheckValue(iDstType, str) || Check.CheckValue(iSrc1, str) || Check.CheckValue(iSrc1Type, str) || Check.CheckValue(iOp, str) || Check.CheckValue(iSrc2, str) || Check.CheckValue(iSrc2Type, str))
		{
			return true;
		}
		return false;
	}
}
