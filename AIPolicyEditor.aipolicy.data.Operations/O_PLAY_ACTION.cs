using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_PLAY_ACTION
{
	public string szActionName { get; set; }
	public int iLoopCount { get; set; }
	public int iInterval { get; set; }
	public int iPlayTime { get; set; }
	public int unk1 { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_PLAY_ACTION");
	}

	public static O_PLAY_ACTION Read(BinaryReader br)
	{
		return new O_PLAY_ACTION
		{
			szActionName = br.ReadBytes(128).ByteArray_to_GbkString(),
			iLoopCount = br.ReadInt32(),
			iInterval = br.ReadInt32(),
			iPlayTime = br.ReadInt32(),
			unk1 = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_PLAY_ACTION param)
	{
		bw.Write(param.szActionName.GbkString_to_ByteArray(128));
		bw.Write(param.iLoopCount);
		bw.Write(param.iInterval);
		bw.Write(param.iPlayTime);
		bw.Write(param.unk1);
	}

	public object Copy()
	{
		return new O_PLAY_ACTION
		{
			szActionName = szActionName,
			iLoopCount = iLoopCount,
			iInterval = iInterval,
			iPlayTime = iPlayTime,
			unk1 = unk1,
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(szActionName, str) 
			|| Check.CheckValue(iLoopCount, str) 
			|| Check.CheckValue(iInterval, str) 
			|| Check.CheckValue(iPlayTime, str)
			|| Check.CheckValue(unk1, str))
		{
			return true;
		}
		
		return false;
	}
}
