using System;
using AIPolicyEditor.aipolicy.data;

namespace AIPolicyEditor;

internal class Check
{
	public static bool CheckValue(bool value, string str)
	{
		if (bool.TryParse(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(int value, string str)
	{
		if (int.TryParse(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicySummoneeDisppearType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicySummoneeDisppearType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyMonsterPatrolType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyMonsterPatrolType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyMonsterPatrolSpeedType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyMonsterPatrolSpeedType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyFactionPVPPointType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyFactionPVPPointType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyVarType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyVarType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyOperatorType value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyOperatorType>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyTalkTextAppendDataMask value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyTalkTextAppendDataMask>(str, out var result) && value.HasFlag(result))
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyOccupationMask value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyOccupationMask>(str, out var result) && value.HasFlag(result))
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(CTriggerData.enumPolicyChatChannel value, string str)
	{
		if (Enum.TryParse<CTriggerData.enumPolicyChatChannel>(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(float value, string str)
	{
		if (float.TryParse(str, out var result) && value == result)
		{
			return true;
		}
		return false;
	}

	public static bool CheckValue(string value, string str)
	{
		if (value.ToLower().Contains(str.ToLower()))
		{
			return true;
		}
		return false;
	}
}
