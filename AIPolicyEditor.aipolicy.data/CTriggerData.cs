using System;
using System.Collections.ObjectModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

public class CTriggerData
{
	public enum enumPolicySummoneeDisppearType
	{
		enumPSDTNever,
		enumPSDTFollowSummoner,
		enumPSDTFollowSummonTarget,
		enumPSDTFollowSummonerOrSummonTarget,
		enumPSDTNum
	}

	public enum enumPolicyMonsterPatrolType
	{
		enumPMPTStopAtEnd,
		enumPMPTReturn,
		enumPMPTLoop,
		enumPMPTNum
	}

	public enum enumPolicyMonsterPatrolSpeedType
	{
		enumPMPSTBegin,
		enumPMPSTSlow,
		enumPMPSTFast,
		enumPMPSTEnd
	}

	public enum enumPolicyFactionPVPPointType
	{
		enumPFPPTMineCar,
		enumPFPPTMineBase,
		enumPFPPTMineCarArrived
	}

	public enum enumPolicyVarType
	{
		enumPVTGlobalVarID,
		enumPVTLocalVarID,
		enumPVTConst,
		enumPVTRandom,
		enumPVTNum
	}

	public enum enumPolicyOperatorType
	{
		enumPOTAdd,
		enumPOTSub,
		enumPOTMul,
		enumPOTDiv,
		enumPOTMod,
		enumPOTNum
	}

	[Flags]
	public enum enumPolicyTalkTextAppendDataMask
	{
		enumPTTADMName = 1,
		enumPTTADMLocalVar0 = 2,
		enumPTTADMLocalVar1 = 4,
		enumPTTADMLocalVar2 = 8,
		enumPTTADMTalkingName = 0x10,
		enumPTTADM6 = 0x20
	}

	[Flags]
	public enum enumPolicyOccupationMask
	{
		enumPOMBlademaster = 1,
		enumPOMWizard = 2,
		enumPOMPsychic = 4,
		enumPOMVenomancer = 8,
		enumPOMBarbarian = 0x10,
		enumPOMAssassin = 0x20,
		enumPOMArcher = 0x40,
		enumPOMCleric = 0x80,
		enumPOMSeeker = 0x100,
		enumPOMMystic = 0x200,
		enumPOMDuskblade = 0x400,
		enumPOMStormbringer = 0x800,
		enumPOMTechnician = 0x1000,
		enumPOMEdgerunner = 0x2000
	}

	public enum enumPolicyChatChannel
	{
		enumPCCNormal,
		enumPCCFaction,
		enumPCCAnonymous,
		enumPCCBroadcast,
		enumPCCInstance,
		enumPCCSystem,
		enumPCCInstanceCenterScreen,
		enumPCCWhisper
	}

	public int dwVersion { get; set; }

	public int uID { get; set; }

	public bool bActive { get; set; }

	public bool bRun { get; set; }

	public bool bAttackValid { get; set; }

	public string szName { get; set; }

	public _s_tree_item rootConditon { get; set; } = new _s_tree_item();


	public ObservableCollection<_s_operation> listOperation { get; set; } = new ObservableCollection<_s_operation>();


	public void Read(BinaryReader br, int listPolicy, int listTriggerPtr)
	{
		dwVersion = br.ReadInt32();
		uID = br.ReadInt32();
		bActive = br.ReadBoolean();
		bRun = br.ReadBoolean();
		bAttackValid = br.ReadBoolean();
		szName = br.ReadBytes(128).ByteArray_to_GbkString();
		rootConditon.Read(br, listPolicy, listTriggerPtr);
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			_s_operation s_operation = new _s_operation();
			s_operation.Read(br, dwVersion, listPolicy, listTriggerPtr, i);
			listOperation.Add(s_operation);
		}
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(dwVersion);
		bw.Write(uID);
		bw.Write(bActive);
		bw.Write(bRun);
		bw.Write(bAttackValid);
		bw.Write(szName.GbkString_to_ByteArray(128));
		rootConditon.Write(bw);
		bw.Write(listOperation.Count);
		for (int i = 0; i < listOperation.Count; i++)
		{
			listOperation[i].Write(bw, dwVersion);
		}
	}

	public object Copy()
	{
		CTriggerData cTriggerData = new CTriggerData
		{
			dwVersion = dwVersion,
			uID = uID,
			bActive = bActive,
			bRun = bRun,
			bAttackValid = bAttackValid,
			szName = szName,
			rootConditon = (rootConditon.Copy() as _s_tree_item)
		};
		foreach (_s_operation item in listOperation)
		{
			cTriggerData.listOperation.Add(item.Copy(dwVersion) as _s_operation);
		}
		return cTriggerData;
	}
}
