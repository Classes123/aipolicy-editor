using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using AIPolicyEditor.Editors;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_53
{
	public int uSize;

	public string szData { get; set; }

	[Editor(typeof(enumPolicyTalkTextAppendDataMaskEditor), typeof(UITypeEditor))]
	public CTriggerData.enumPolicyTalkTextAppendDataMask uAppendDataMask { get; set; }

	public int unk1 { get; set; }

	public CTriggerData.enumPolicyVarType unk1Type { get; set; }

	public int unk2 { get; set; }

	public CTriggerData.enumPolicyVarType unk2Type { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_53");
	}

	public static O_53 Read(BinaryReader br)
	{
		O_53 o_ = new O_53();
		o_.uSize = br.ReadInt32();
		o_.szData = br.ReadBytes(o_.uSize).ByteArray_to_UnicodeString();
		o_.uAppendDataMask = (CTriggerData.enumPolicyTalkTextAppendDataMask)br.ReadInt32();
		o_.unk1 = br.ReadInt32();
		o_.unk1Type = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		o_.unk2 = br.ReadInt32();
		o_.unk2Type = (CTriggerData.enumPolicyVarType)br.ReadInt32();
		return o_;
	}

	public static void Write(BinaryWriter bw, O_53 param)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(param.szData + "\0");
		bw.Write(bytes.Length);
		bw.Write(bytes);
		bw.Write((int)param.uAppendDataMask);
		bw.Write(param.unk1);
		bw.Write((int)param.unk1Type);
		bw.Write(param.unk2);
		bw.Write((int)param.unk2Type);
	}

	public object Copy()
	{
		return new O_53
		{
			uSize = uSize,
			szData = szData,
			uAppendDataMask = uAppendDataMask,
			unk1 = unk1,
			unk1Type = unk1Type,
			unk2 = unk2,
			unk2Type = unk2Type
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(szData, str) || Check.CheckValue(uAppendDataMask, str) || Check.CheckValue(unk1, str) || Check.CheckValue(unk1Type, str) || Check.CheckValue(unk2, str) || Check.CheckValue(unk2Type, str))
		{
			return true;
		}
		return false;
	}
}
