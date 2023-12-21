using System.ComponentModel;
using System.IO;
using AIPolicyEditor.aipolicy.data.Targets;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class _s_target
{
	public enum _e_target
	{
		t_hate_first,
		t_hate_second,
		t_hate_others,
		t_most_hp,
		t_most_mp,
		t_least_hp,
		t_occupation_list,
		t_self,
		t_monster_killer,
		t_monster_birthplace_faction,
		t_hate_random_one,
		t_hate_nearest,
		t_hate_farthest,
		t_hate_first_redirected,
		t_14,
		t_15,
		t_16,
		t_17,
		t_18,
		t_num
	}

	private _e_target _iType;

	public _e_target iType
	{
		get
		{
			return _iType;
		}
		set
		{
			_iType = value;
			if (!MainWindow.LockTarget)
			{
				switch (iType)
				{
				case _e_target.t_occupation_list:
					pParam = new T_OCCUPATION();
					break;
				case _e_target.t_14:
					pParam = new T_14();
					break;
				case _e_target.t_15:
					pParam = new T_15();
					break;
				case _e_target.t_16:
					pParam = new T_16();
					break;
				case _e_target.t_18:
					pParam = new T_18();
					break;
				default:
					pParam = null;
					break;
				}
			}
		}
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public object pParam { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "s_target");
	}

	public void Read(BinaryReader br, int dwVersion, int listPolicy, int listTriggerPtr, int listOperation)
	{
		iType = (_e_target)br.ReadInt32();
		switch (iType)
		{
		case _e_target.t_occupation_list:
			pParam = T_OCCUPATION.Read(br);
			break;
		case _e_target.t_14:
			pParam = T_14.Read(br);
			break;
		case _e_target.t_15:
			pParam = T_15.Read(br);
			break;
		case _e_target.t_16:
			pParam = T_16.Read(br);
			break;
		case _e_target.t_18:
			pParam = T_18.Read(br);
			break;
		case _e_target.t_hate_first:
		case _e_target.t_hate_second:
		case _e_target.t_hate_others:
		case _e_target.t_most_hp:
		case _e_target.t_most_mp:
		case _e_target.t_least_hp:
		case _e_target.t_self:
		case _e_target.t_monster_killer:
		case _e_target.t_monster_birthplace_faction:
		case _e_target.t_hate_random_one:
		case _e_target.t_hate_nearest:
		case _e_target.t_hate_farthest:
		case _e_target.t_hate_first_redirected:
		case _e_target.t_17:
			break;
		}
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write((int)iType);
		switch (iType)
		{
		case _e_target.t_occupation_list:
			T_OCCUPATION.Write(bw, (T_OCCUPATION)pParam);
			break;
		case _e_target.t_14:
			T_14.Write(bw, (T_14)pParam);
			break;
		case _e_target.t_15:
			T_15.Write(bw, (T_15)pParam);
			break;
		case _e_target.t_16:
			T_16.Write(bw, (T_16)pParam);
			break;
		case _e_target.t_18:
			T_18.Write(bw, (T_18)pParam);
			break;
		}
	}

	public object Copy()
	{
		_s_target s_target = new _s_target();
		s_target.iType = iType;
		switch (iType)
		{
		case _e_target.t_occupation_list:
			s_target.pParam = (pParam as T_OCCUPATION).Copy();
			break;
		case _e_target.t_14:
			s_target.pParam = (pParam as T_14).Copy();
			break;
		case _e_target.t_15:
			s_target.pParam = (pParam as T_15).Copy();
			break;
		case _e_target.t_16:
			s_target.pParam = (pParam as T_16).Copy();
			break;
		case _e_target.t_18:
			s_target.pParam = (pParam as T_18).Copy();
			break;
		}
		return s_target;
	}

	public bool Search(string str)
	{
		bool result = false;
		switch (iType)
		{
		case _e_target.t_occupation_list:
			result = (pParam as T_OCCUPATION).Search(str);
			break;
		case _e_target.t_14:
			result = (pParam as T_14).Search(str);
			break;
		case _e_target.t_15:
			result = (pParam as T_15).Search(str);
			break;
		case _e_target.t_16:
			result = (pParam as T_16).Search(str);
			break;
		case _e_target.t_18:
			result = (pParam as T_18).Search(str);
			break;
		}
		return result;
	}
}
