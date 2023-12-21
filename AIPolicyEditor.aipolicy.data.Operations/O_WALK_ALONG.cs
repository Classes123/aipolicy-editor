using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_WALK_ALONG
{
	public int iWorldID { get; set; }

	public int iPathID { get; set; }

	public CTriggerData.enumPolicyMonsterPatrolType iPatrolType { get; set; }

	public CTriggerData.enumPolicyMonsterPatrolSpeedType iSpeedType { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_WALK_ALONG");
	}

	public static O_WALK_ALONG Read(BinaryReader br)
	{
		return new O_WALK_ALONG
		{
			iWorldID = br.ReadInt32(),
			iPathID = br.ReadInt32(),
			iPatrolType = (CTriggerData.enumPolicyMonsterPatrolType)br.ReadInt32(),
			iSpeedType = (CTriggerData.enumPolicyMonsterPatrolSpeedType)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_WALK_ALONG param)
	{
		bw.Write(param.iWorldID);
		bw.Write(param.iPathID);
		bw.Write((int)param.iPatrolType);
		bw.Write((int)param.iSpeedType);
	}

	public object Copy()
	{
		return new O_WALK_ALONG
		{
			iWorldID = iWorldID,
			iPathID = iPathID,
			iPatrolType = iPatrolType,
			iSpeedType = iSpeedType
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iWorldID, str) || Check.CheckValue(iPathID, str) || Check.CheckValue(iPatrolType, str) || Check.CheckValue(iSpeedType, str))
		{
			return true;
		}
		return false;
	}
}
