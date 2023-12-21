using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_64
{
	private byte[] bytes = new byte[3];

	public bool bStop { get; set; }

	public POLICY_CONTROLLER_LIST[] clControllers { get; set; } = new POLICY_CONTROLLER_LIST[10];


	public override string ToString()
	{
		return string.Format("{0}", "O_64");
	}

	public static O_64 Read(BinaryReader br)
	{
		O_64 o_ = new O_64();
		o_.bStop = br.ReadBoolean();
		o_.bytes = br.ReadBytes(3);
		for (int i = 0; i < 10; i++)
		{
			o_.clControllers[i] = POLICY_CONTROLLER_LIST.Read(br);
		}
		return o_;
	}

	public static void Write(BinaryWriter bw, O_64 param)
	{
		bw.Write(param.bStop);
		bw.Write(param.bytes);
		for (int i = 0; i < 10; i++)
		{
			POLICY_CONTROLLER_LIST.Write(bw, param.clControllers[i]);
		}
	}

	public object Copy()
	{
		O_64 o_ = new O_64();
		o_.bStop = bStop;
		for (int i = 0; i < 10; i++)
		{
			o_.clControllers[i] = clControllers[i].Copy();
		}
		return o_;
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(bStop, str))
		{
			return true;
		}
		for (int i = 0; i < 10; i++)
		{
			if (clControllers[i].Search(str))
			{
				return true;
			}
		}
		return false;
	}
}
