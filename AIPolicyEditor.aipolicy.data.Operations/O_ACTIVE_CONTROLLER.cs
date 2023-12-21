using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_ACTIVE_CONTROLLER
{
	private byte[] bytes = new byte[3];

	public int uID { get; set; }

	public bool bStop { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_ACTIVE_CONTROLLER");
	}

	public static O_ACTIVE_CONTROLLER Read(BinaryReader br, int version)
	{
		O_ACTIVE_CONTROLLER o_ACTIVE_CONTROLLER = new O_ACTIVE_CONTROLLER();
		o_ACTIVE_CONTROLLER.uID = br.ReadInt32();
		if (version >= 1)
		{
			o_ACTIVE_CONTROLLER.bStop = br.ReadBoolean();
			o_ACTIVE_CONTROLLER.bytes = br.ReadBytes(3);
		}
		return o_ACTIVE_CONTROLLER;
	}

	public static void Write(BinaryWriter bw, O_ACTIVE_CONTROLLER param, int version)
	{
		bw.Write(param.uID);
		if (version >= 1)
		{
			bw.Write(param.bStop);
			bw.Write(param.bytes);
		}
	}

	public object Copy()
	{
		return new O_ACTIVE_CONTROLLER
		{
			uID = uID,
			bStop = bStop
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str) || Check.CheckValue(bStop, str))
		{
			return true;
		}
		return false;
	}
}
