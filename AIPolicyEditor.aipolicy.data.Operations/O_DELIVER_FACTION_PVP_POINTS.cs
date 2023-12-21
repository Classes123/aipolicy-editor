using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_DELIVER_FACTION_PVP_POINTS
{
	public CTriggerData.enumPolicyFactionPVPPointType uType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_DELIVER_FACTION_PVP_POINTS");
	}

	public static O_DELIVER_FACTION_PVP_POINTS Read(BinaryReader br)
	{
		return new O_DELIVER_FACTION_PVP_POINTS
		{
			uType = (CTriggerData.enumPolicyFactionPVPPointType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_DELIVER_FACTION_PVP_POINTS param)
	{
		bw.Write((int)param.uType);
	}

	public object Copy()
	{
		return new O_DELIVER_FACTION_PVP_POINTS
		{
			uType = uType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uType, str))
		{
			return true;
		}
		return false;
	}
}
