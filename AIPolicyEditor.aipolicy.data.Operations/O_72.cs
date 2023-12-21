using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using AIPolicyEditor.Editors;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_72
{
	public int uSize;

	public CTriggerData.enumPolicyChatChannel ChatChannel { get; set; }

	public string szData { get; set; }

	[Editor(typeof(enumPolicyTalkTextAppendDataMaskEditor), typeof(UITypeEditor))]
	public CTriggerData.enumPolicyTalkTextAppendDataMask uAppendDataMask { get; set; }

	public POLICY_ZONE_VERT zvMin { get; set; } = new POLICY_ZONE_VERT();


	public POLICY_ZONE_VERT zvMax { get; set; } = new POLICY_ZONE_VERT();


	public override string ToString()
	{
		return string.Format("{0}", "O_72");
	}

	public static O_72 Read(BinaryReader br)
	{
		O_72 o_ = new O_72();
		o_.uSize = br.ReadInt32();
		o_.szData = br.ReadBytes(o_.uSize).ByteArray_to_UnicodeString();
		o_.ChatChannel = Channel.Get(o_.szData);
		if (o_.ChatChannel != 0)
		{
			o_.szData = o_.szData.Remove(0, 2);
		}
		o_.uAppendDataMask = (CTriggerData.enumPolicyTalkTextAppendDataMask)br.ReadInt32();
		o_.zvMin.Read(br);
		o_.zvMax.Read(br);
		return o_;
	}

	public static void Write(BinaryWriter bw, O_72 param)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(Channel.Set(param.ChatChannel) + param.szData + "\0");
		bw.Write(bytes.Length);
		bw.Write(bytes);
		bw.Write((int)param.uAppendDataMask);
		param.zvMin.Write(bw);
		param.zvMax.Write(bw);
	}

	public object Copy()
	{
		return new O_72
		{
			uSize = uSize,
			ChatChannel = ChatChannel,
			szData = szData,
			uAppendDataMask = uAppendDataMask,
			zvMin = (zvMin.Copy() as POLICY_ZONE_VERT),
			zvMax = (zvMax.Copy() as POLICY_ZONE_VERT)
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(ChatChannel, str) || Check.CheckValue(szData, str) || Check.CheckValue(uAppendDataMask, str) || zvMin.Search(str) || zvMax.Search(str))
		{
			return true;
		}
		return false;
	}
}
