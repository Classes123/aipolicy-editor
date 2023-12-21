using AIPolicyEditor.aipolicy.data;

namespace AIPolicyEditor;

internal class Channel
{
	public static CTriggerData.enumPolicyChatChannel Get(string Data)
	{
		if (Data.StartsWith("$"))
		{
			return Data.Substring(0, 2) switch
			{
				"$F" => CTriggerData.enumPolicyChatChannel.enumPCCFaction, 
				"$A" => CTriggerData.enumPolicyChatChannel.enumPCCAnonymous, 
				"$B" => CTriggerData.enumPolicyChatChannel.enumPCCBroadcast, 
				"$I" => CTriggerData.enumPolicyChatChannel.enumPCCInstance, 
				"$S" => CTriggerData.enumPolicyChatChannel.enumPCCSystem, 
				"$X" => CTriggerData.enumPolicyChatChannel.enumPCCInstanceCenterScreen, 
				"$W" => CTriggerData.enumPolicyChatChannel.enumPCCWhisper, 
				_ => CTriggerData.enumPolicyChatChannel.enumPCCNormal, 
			};
		}
		return CTriggerData.enumPolicyChatChannel.enumPCCNormal;
	}

	public static string Set(CTriggerData.enumPolicyChatChannel ChatChannel)
	{
		return ChatChannel switch
		{
			CTriggerData.enumPolicyChatChannel.enumPCCFaction => "$F", 
			CTriggerData.enumPolicyChatChannel.enumPCCAnonymous => "$A", 
			CTriggerData.enumPolicyChatChannel.enumPCCBroadcast => "$B", 
			CTriggerData.enumPolicyChatChannel.enumPCCInstance => "$I", 
			CTriggerData.enumPolicyChatChannel.enumPCCSystem => "$S", 
			CTriggerData.enumPolicyChatChannel.enumPCCInstanceCenterScreen => "$X", 
			CTriggerData.enumPolicyChatChannel.enumPCCWhisper => "$W", 
			_ => "", 
		};
	}
}
