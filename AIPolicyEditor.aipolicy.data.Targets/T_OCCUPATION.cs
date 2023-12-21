using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using AIPolicyEditor.Editors;

namespace AIPolicyEditor.aipolicy.data.Targets;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class T_OCCUPATION
{
	[Editor(typeof(OccupationEditor), typeof(UITypeEditor))]
	public CTriggerData.enumPolicyOccupationMask uBit { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "T_OCCUPATION");
	}

	public static T_OCCUPATION Read(BinaryReader br)
	{
		return new T_OCCUPATION
		{
			uBit = (CTriggerData.enumPolicyOccupationMask)br.ReadInt32()
		};
	}

	public static void Write(BinaryWriter bw, T_OCCUPATION param)
	{
		bw.Write((int)param.uBit);
	}

	public object Copy()
	{
		return new T_OCCUPATION
		{
			uBit = uBit
		};
	}

	public bool Search(string str)
	{
		if (Check.CheckValue(uBit, str))
		{
			return true;
		}
		return false;
	}
}
