using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Conditions;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class C_TIME_COME
{
	public int uID { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "C_TIME_COME");
	}

	public static C_TIME_COME Read(BinaryReader br)
	{
		return new C_TIME_COME
		{
			uID = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, C_TIME_COME param)
	{
		bw.Write(param.uID);
	}

	public object Copy()
	{
		return new C_TIME_COME
		{
			uID = uID
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uID, str))
		{
			return true;
		}
		return false;
	}
}
