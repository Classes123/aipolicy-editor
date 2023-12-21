using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_43
{
	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public int iTargetID { get; set; }

	public CTriggerData.enumPolicyVarType uTargetType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_43");
	}

	public static O_43 Read(BinaryReader br)
	{
		O_43 o_ = new O_43();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		o_.iTargetID = br.ReadInt32();
		o_.uTargetType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		return o_;
	}

	public static void Write(BinaryWriter bw, O_43 param)
	{
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
		bw.Write(param.iTargetID);
		bw.Write((int)param.uTargetType);
	}

	public object Copy()
	{
		return new O_43
		{
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT),
			iTargetID = iTargetID,
			uTargetType = uTargetType
		};
	}

	public bool Search(string str)
	{
		if (zvMin.Search(str) || zvMax.Search(str) || Check.CheckValue(iTargetID, str) || Check.CheckValue(uTargetType, str))
		{
			return true;
		}
		return false;
	}
}
