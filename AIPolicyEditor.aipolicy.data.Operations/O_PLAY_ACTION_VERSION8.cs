using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_PLAY_ACTION_VERSION8
{
	public string szActionName { get; set; }

	public bool bLoop { get; set; }

	public int iInterval { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_PLAY_ACTION");
	}

	public static O_PLAY_ACTION_VERSION8 Read(BinaryReader br)
	{
		O_PLAY_ACTION_VERSION8 obj = new O_PLAY_ACTION_VERSION8
		{
			szActionName = br.ReadBytes(128).ByteArray_to_GbkString(),
			bLoop = br.ReadBoolean()
		};
		br.ReadBytes(3);
		obj.iInterval = br.ReadInt32();
		return obj;
	}

	public static void Write(BinaryWriter bw, O_PLAY_ACTION_VERSION8 param)
	{
		bw.Write(param.szActionName.GbkString_to_ByteArray(128));
		bw.Write(param.bLoop);
		bw.Write(new byte[3]);
		bw.Write(param.iInterval);
	}

	public object Copy()
	{
		return new O_PLAY_ACTION_VERSION8
		{
			szActionName = szActionName,
			bLoop = bLoop,
			iInterval = iInterval
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(szActionName, str) || Check.CheckValue(bLoop, str) || Check.CheckValue(iInterval, str))
		{
			return true;
		}
		return false;
	}
}
