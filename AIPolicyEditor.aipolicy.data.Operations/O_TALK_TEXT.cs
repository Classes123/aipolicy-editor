using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using AIPolicyEditor.Editors;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class O_TALK_TEXT
{
	public int uSize;

	public CTriggerData.enumPolicyChatChannel ChatChannel { get; set; }

	public string szData { get; set; }

	[Editor(typeof(enumPolicyTalkTextAppendDataMaskEditor), typeof(UITypeEditor))]
	public CTriggerData.enumPolicyTalkTextAppendDataMask uAppendDataMask { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_TALK_TEXT");
	}

	public static O_TALK_TEXT Read(BinaryReader br, int version)
	{
		O_TALK_TEXT o_TALK_TEXT = new O_TALK_TEXT();
		o_TALK_TEXT.uSize = br.ReadInt32();
		o_TALK_TEXT.szData = br.ReadBytes(o_TALK_TEXT.uSize).ByteArray_to_UnicodeString();
		o_TALK_TEXT.ChatChannel = Channel.Get(o_TALK_TEXT.szData);
		if (o_TALK_TEXT.ChatChannel != 0)
		{
			o_TALK_TEXT.szData = o_TALK_TEXT.szData.Remove(0, 2);
		}
		if (version >= 17)
		{
			o_TALK_TEXT.uAppendDataMask = (CTriggerData.enumPolicyTalkTextAppendDataMask)br.ReadInt32();
		}
		return o_TALK_TEXT;
	}

	public static void Write(BinaryWriter bw, O_TALK_TEXT param, int version)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(Channel.Set(param.ChatChannel) + param.szData + "\0");
		bw.Write(bytes.Length);
		bw.Write(bytes);
		if (version >= 17)
		{
			bw.Write((int)param.uAppendDataMask);
		}
	}

	public object Copy()
	{
		return new O_TALK_TEXT
		{
			uSize = uSize,
			ChatChannel = ChatChannel,
			szData = szData,
			uAppendDataMask = uAppendDataMask
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(ChatChannel, str) || Check.CheckValue(szData, str) || Check.CheckValue(uAppendDataMask, str))
		{
			return true;
		}
		return false;
	}
}
