using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using AIPolicyEditor.Editors;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_36
{
	public int uSize;

	public int uSkill { get; set; }

	public CTriggerData.enumPolicyVarType uSkillType { get; set; }

	public int uLevel { get; set; }

	public CTriggerData.enumPolicyVarType uLevelType { get; set; }

	public CTriggerData.enumPolicyChatChannel ChatChannel { get; set; }

	public string szData { get; set; }

	[Editor(typeof(enumPolicyTalkTextAppendDataMaskEditor), typeof(UITypeEditor))]
	public CTriggerData.enumPolicyTalkTextAppendDataMask uAppendDataMask { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_36");
	}

	public static O_36 Read(BinaryReader br)
	{
		O_36 o_ = new O_36();
		o_.uSkill = br.ReadInt32();
		o_.uSkillType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_.uLevel = br.ReadInt32();
		o_.uLevelType = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_.uSize = br.ReadInt32();
		o_.szData = br.ReadBytes(o_.uSize).ByteArray_to_UnicodeString();
		o_.ChatChannel = Channel.Get(o_.szData);
		if (o_.ChatChannel != 0)
		{
			o_.szData = o_.szData.Remove(0, 2);
		}
		o_.uAppendDataMask = (CTriggerData.enumPolicyTalkTextAppendDataMask)br.ReadInt32();
		return o_;
	}

	public static void Write(BinaryWriter bw, O_36 param)
	{
		bw.Write(param.uSkill);
		bw.Write((int)param.uSkillType);
		bw.Write(param.uLevel);
		bw.Write((int)param.uLevelType);
		byte[] bytes = Encoding.Unicode.GetBytes(Channel.Set(param.ChatChannel) + param.szData + "\0");
		bw.Write(bytes.Length);
		bw.Write(bytes);
		bw.Write((int)param.uAppendDataMask);
	}

	public object Copy()
	{
		return new O_36
		{
			uSkill = uSkill,
			uSkillType = uSkillType,
			uLevel = uLevel,
			uLevelType = uLevelType,
			uSize = uSize,
			ChatChannel = ChatChannel,
			szData = szData,
			uAppendDataMask = uAppendDataMask
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uSkill, str) || Check.CheckValue(uSkillType, str) || Check.CheckValue(uLevel, str) || Check.CheckValue(uLevelType, str) || Check.CheckValue(ChatChannel, str) || Check.CheckValue(szData, str) || Check.CheckValue(uAppendDataMask, str))
		{
			return true;
		}
		return false;
	}
}
