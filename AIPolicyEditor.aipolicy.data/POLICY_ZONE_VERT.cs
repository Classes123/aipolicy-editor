using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal class POLICY_ZONE_VERT
{
	public float[] v { get; set; } = new float[3];


	public override string ToString()
	{
		return string.Format("{0}", "POLICY_ZONE_VERT");
	}

	public void Read(BinaryReader br)
	{
		for (int i = 0; i < v.Length; i++)
		{
			v[i] = br.ReadSingle();
		}
	}

	public void Write(BinaryWriter bw)
	{
		for (int i = 0; i < v.Length; i++)
		{
			bw.Write(v[i]);
		}
	}

	public object Copy()
	{
		POLICY_ZONE_VERT pOLICY_ZONE_VERT = new POLICY_ZONE_VERT();
		for (int i = 0; i < v.Length; i++)
		{
			pOLICY_ZONE_VERT.v[i] = v[i];
		}
		return pOLICY_ZONE_VERT;
	}

	public bool Search(string str)
	{
		for (int i = 0; i < v.Length; i++)
		{
			if (Check.CheckValue(v[i], str))
			{
				return true;
			}
		}
		return false;
	}
}
