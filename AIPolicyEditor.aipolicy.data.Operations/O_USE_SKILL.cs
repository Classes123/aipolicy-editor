using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data.Operations;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class O_USE_SKILL
{
	public int uSkill { get; set; }

	public int uLevel { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "O_USE_SKILL");
	}

	public static O_USE_SKILL Read(BinaryReader br)
	{
		return new O_USE_SKILL
		{
			uSkill = br.ReadInt32(),
			uLevel = br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, O_USE_SKILL param)
	{
		bw.Write(param.uSkill);
		bw.Write(param.uLevel);
	}

	public object Copy()
	{
		return new O_USE_SKILL
		{
			uSkill = uSkill,
			uLevel = uLevel
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uSkill, str) || Check.CheckValue(uLevel, str))
		{
			return true;
		}
		return false;
	}
}
