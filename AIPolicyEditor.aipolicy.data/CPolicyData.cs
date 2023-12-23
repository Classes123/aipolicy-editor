using System;
using System.Collections.ObjectModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

public class CPolicyData
{
	public int nVersion;

	public int uID;

	public ObservableCollection<CTriggerData> listTriggerPtr = new ObservableCollection<CTriggerData>();

	public void Read(BinaryReader br, int listPolicy)
	{
		nVersion = br.ReadInt32();
		uID = br.ReadInt32();
		
		int num = br.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			CTriggerData cTriggerData = new CTriggerData();
			cTriggerData.Read(br, listPolicy, i);
			listTriggerPtr.Add(cTriggerData);
		}
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write(nVersion);
		bw.Write(uID);
		bw.Write(listTriggerPtr.Count);
		for (int i = 0; i < listTriggerPtr.Count; i++)
		{
			listTriggerPtr[i].Write(bw);
		}
	}

	public object Copy()
	{
		CPolicyData cPolicyData = new CPolicyData
		{
			nVersion = nVersion,
			uID = uID
		};
		foreach (CTriggerData item in listTriggerPtr)
		{
			cPolicyData.listTriggerPtr.Add(item.Copy() as CTriggerData);
		}
		return cPolicyData;
	}
}
