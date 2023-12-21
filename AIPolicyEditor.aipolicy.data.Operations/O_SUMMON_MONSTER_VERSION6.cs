using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_SUMMON_MONSTER_VERSION6
{
	public int iMonsterID { get; set; }

	public int iRange { get; set; }

	public int iLife { get; set; }

	public bool bDispear { get; set; }

	public bool bUsePolicyTarget { get; set; }

	public int iPathID { get; set; }

	public int iMonsterNum { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_SUMMON_MONSTER");
	}

	public static O_SUMMON_MONSTER_VERSION6 Read(BinaryReader br)
	{
		O_SUMMON_MONSTER_VERSION6 obj = new O_SUMMON_MONSTER_VERSION6
		{
			iMonsterID = br.ReadInt32(),
			iRange = br.ReadInt32(),
			iLife = br.ReadInt32(),
			bDispear = br.ReadBoolean()
		};
		br.ReadBytes(3);
		obj.bUsePolicyTarget = br.ReadBoolean();
		br.ReadBytes(3);
		obj.iPathID = br.ReadInt32();
		obj.iMonsterNum = br.ReadInt32();
		return obj;
	}

	public static void Write(BinaryWriter bw, O_SUMMON_MONSTER_VERSION6 param)
	{
		bw.Write(param.iMonsterID);
		bw.Write(param.iRange);
		bw.Write(param.iLife);
		bw.Write(param.bDispear);
		bw.Write(new byte[3]);
		bw.Write(param.bUsePolicyTarget);
		bw.Write(new byte[3]);
		bw.Write(param.iPathID);
		bw.Write(param.iMonsterNum);
	}

	public object Copy()
	{
		return new O_SUMMON_MONSTER_VERSION6
		{
			iMonsterID = iMonsterID,
			iRange = iRange,
			iLife = iLife,
			bDispear = bDispear,
			bUsePolicyTarget = bUsePolicyTarget,
			iPathID = iPathID,
			iMonsterNum = iMonsterNum
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(iMonsterID, str) || Check.CheckValue(iRange, str) || Check.CheckValue(iLife, str) || Check.CheckValue(bDispear, str) || Check.CheckValue(bUsePolicyTarget, str) || Check.CheckValue(iPathID, str) || Check.CheckValue(iMonsterNum, str))
		{
			return true;
		}
		return false;
	}
}
