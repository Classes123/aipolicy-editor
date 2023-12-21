using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_63
{
	public int uID { get; set; }

	public CTriggerData.enumPolicyVarType uIDType { get; set; }

	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_63");
	}

	public static O_63 Read(BinaryReader br)
	{
		O_63 o_ = new O_63();
		o_.uID = br.ReadInt32();
		o_.uIDType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		return o_;
	}

	public static void Write(BinaryWriter bw, O_63 param)
	{
		bw.Write(param.uID);
		bw.Write((int)param.uIDType);
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_63
		{
			uID = uID,
			uIDType = uIDType,
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(uIDType, str) || zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
