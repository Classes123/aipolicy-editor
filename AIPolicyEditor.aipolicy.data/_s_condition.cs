using System.ComponentModel;
using System.IO;
using AIPolicyEditor.aipolicy.data.Conditions;
using System.Windows.Forms;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class _s_condition
{
	public enum _e_condition
	{
		c_time_come,
		c_hp_less,
		c_start_attack,
		c_random,
		c_kill_player,
		c_not,
		c_or,
		c_and,
		c_died,
		c_plus,
		c_minus,
		c_multiply,
		c_divide,
		c_great,
		c_less,
		c_equ,
		c_var,
		c_constant,
		c_be_hurt,
		c_reach_end,
		c_at_history_stage,
		c_history_value,
		c_stop_fight,
		c_local_var,
		c_reach_end_2,
		c_has_filter,
		c_room_index,
		c_player_count_in_radius,
		c_player_count_in_region,
		c_29,
		c_30,
		c_31,
		c_32,
		c_33,
		c_34,
		c_35,
		c_36,
		c_37,
		c_38,
		c_39,
		c_40,
		c_num
	}

	private _e_condition _iType { get; set; }

	public _e_condition iType
	{
		get
		{
			return _iType;
		}
		set
		{
			_iType = value;
			if (!MainWindow.LockCondition)
			{
				switch (iType)
				{
				case _e_condition.c_time_come:
					pParam = new C_TIME_COME();
					break;
				case _e_condition.c_hp_less:
					pParam = new C_HP_LESS();
					break;
				case _e_condition.c_random:
					pParam = new C_RANDOM();
					break;
				case _e_condition.c_var:
					pParam = new C_VAR();
					break;
				case _e_condition.c_constant:
					pParam = new C_CONSTANT();
					break;
				case _e_condition.c_be_hurt:
					pParam = new C_BE_HURT();
					break;
				case _e_condition.c_reach_end:
					pParam = new C_REACH_END();
					break;
				case _e_condition.c_at_history_stage:
					pParam = new C_HISTORY_STAGE();
					break;
				case _e_condition.c_history_value:
					pParam = new C_HISTORY_VALUE();
					break;
				case _e_condition.c_local_var:
					pParam = new C_LOCAL_VAR();
					break;
				case _e_condition.c_reach_end_2:
					pParam = new C_REACH_END_2();
					break;
				case _e_condition.c_has_filter:
					pParam = new C_HAS_FILTER();
					break;
				case _e_condition.c_player_count_in_radius:
					pParam = new C_PLAYER_COUNT_IN_RADIUS();
					break;
				case _e_condition.c_player_count_in_region:
					pParam = new C_PLAYER_COUNT_IN_REGION();
					break;
				case _e_condition.c_29:
					pParam = new C_29();
					break;
				case _e_condition.c_30:
					pParam = new C_30();
					break;
				case _e_condition.c_32:
					pParam = new C_32();
					break;
				case _e_condition.c_34:
					pParam = new C_34();
					break;
				case _e_condition.c_35:
					pParam = new C_35();
					break;
				case _e_condition.c_36:
					pParam = new C_36();
					break;
				case _e_condition.c_37:
					pParam = new C_37();
					break;
				case _e_condition.c_38:
					pParam = new C_38();
					break;
				case _e_condition.c_39:
					pParam = new C_39();
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
		return $"{iType}";
	}

	public void Read(BinaryReader br, int listPolicy, int listTriggerPtr)
	{
		iType = (_e_condition)br.ReadInt32();
		br.ReadInt32();
		switch (iType)
		{
		case _e_condition.c_time_come:
			pParam = C_TIME_COME.Read(br);
			break;
		case _e_condition.c_hp_less:
			pParam = C_HP_LESS.Read(br);
			break;
		case _e_condition.c_random:
			pParam = C_RANDOM.Read(br);
			break;
		case _e_condition.c_var:
			pParam = C_VAR.Read(br);
			break;
		case _e_condition.c_constant:
			pParam = C_CONSTANT.Read(br);
			break;
		case _e_condition.c_be_hurt:
			pParam = C_BE_HURT.Read(br);
			break;
		case _e_condition.c_reach_end:
			pParam = C_REACH_END.Read(br);
			break;
		case _e_condition.c_at_history_stage:
			pParam = C_HISTORY_STAGE.Read(br);
			break;
		case _e_condition.c_history_value:
			pParam = C_HISTORY_VALUE.Read(br);
			break;
		case _e_condition.c_local_var:
			pParam = C_LOCAL_VAR.Read(br);
			break;
		case _e_condition.c_reach_end_2:
			pParam = C_REACH_END_2.Read(br);
			break;
		case _e_condition.c_has_filter:
			pParam = C_HAS_FILTER.Read(br);
			break;
		case _e_condition.c_player_count_in_radius:
			pParam = C_PLAYER_COUNT_IN_RADIUS.Read(br);
			break;
		case _e_condition.c_player_count_in_region:
			pParam = C_PLAYER_COUNT_IN_REGION.Read(br);
			break;
		case _e_condition.c_29:
			pParam = C_29.Read(br);
			break;
		case _e_condition.c_30:
			pParam = C_30.Read(br);
			break;
		case _e_condition.c_32:
			pParam = C_32.Read(br);
			break;
		case _e_condition.c_34:
			pParam = C_34.Read(br);
			break;
		case _e_condition.c_35:
			pParam = C_35.Read(br);
			break;
		case _e_condition.c_36:
			pParam = C_36.Read(br);
			break;
		case _e_condition.c_37:
			pParam = C_37.Read(br);
			break;
		case _e_condition.c_38:
			pParam = C_38.Read(br);
			break;
		case _e_condition.c_39:
			pParam = C_39.Read(br);
			break;
		case _e_condition.c_start_attack:
		case _e_condition.c_kill_player:
		case _e_condition.c_not:
		case _e_condition.c_or:
		case _e_condition.c_and:
		case _e_condition.c_died:
		case _e_condition.c_plus:
		case _e_condition.c_minus:
		case _e_condition.c_multiply:
		case _e_condition.c_divide:
		case _e_condition.c_great:
		case _e_condition.c_less:
		case _e_condition.c_equ:
		case _e_condition.c_stop_fight:
		case _e_condition.c_room_index:
		case _e_condition.c_31:
		case _e_condition.c_33:
		case _e_condition.c_40:
			break;

		default:
			if ((int)iType == 41)
			{
				pParam = br.ReadBytes(4);
				break;
			}

			if ((int)iType == 43)
			{
				pParam = br.ReadBytes(4);
				break;
			}

			if ((int)iType == 42)
			{
				pParam = br.ReadBytes(4);
				break;
			}

			if ((int)iType == 44)
			{
				pParam = br.ReadBytes(4);
				break;
			}

			if ((int)iType == 45)
			{
				pParam = null;
				break;
			}

			if ((int)iType == 46)
			{
				pParam = null;
				break;
			}

			if (iType >= _e_condition.c_num)
			{
				throw new System.InvalidOperationException("Unknown condition " + iType + ":" + (int)iType + " (" + (br.BaseStream.Position - 8) + ")");
			}

			break;
		}
	}

	public void Write(BinaryWriter bw)
	{
		bw.Write((int)iType);
		bw.Write(GetConditionParamSize(iType));
		switch (iType)
		{
		case _e_condition.c_time_come:
			C_TIME_COME.Write(bw, (C_TIME_COME)pParam);
			break;
		case _e_condition.c_hp_less:
			C_HP_LESS.Write(bw, (C_HP_LESS)pParam);
			break;
		case _e_condition.c_random:
			C_RANDOM.Write(bw, (C_RANDOM)pParam);
			break;
		case _e_condition.c_var:
			C_VAR.Write(bw, (C_VAR)pParam);
			break;
		case _e_condition.c_constant:
			C_CONSTANT.Write(bw, (C_CONSTANT)pParam);
			break;
		case _e_condition.c_be_hurt:
			C_BE_HURT.Write(bw, (C_BE_HURT)pParam);
			break;
		case _e_condition.c_reach_end:
			C_REACH_END.Write(bw, (C_REACH_END)pParam);
			break;
		case _e_condition.c_at_history_stage:
			C_HISTORY_STAGE.Write(bw, (C_HISTORY_STAGE)pParam);
			break;
		case _e_condition.c_history_value:
			C_HISTORY_VALUE.Write(bw, (C_HISTORY_VALUE)pParam);
			break;
		case _e_condition.c_local_var:
			C_LOCAL_VAR.Write(bw, (C_LOCAL_VAR)pParam);
			break;
		case _e_condition.c_reach_end_2:
			C_REACH_END_2.Write(bw, (C_REACH_END_2)pParam);
			break;
		case _e_condition.c_has_filter:
			C_HAS_FILTER.Write(bw, (C_HAS_FILTER)pParam);
			break;
		case _e_condition.c_player_count_in_radius:
			C_PLAYER_COUNT_IN_RADIUS.Write(bw, (C_PLAYER_COUNT_IN_RADIUS)pParam);
			break;
		case _e_condition.c_player_count_in_region:
			C_PLAYER_COUNT_IN_REGION.Write(bw, (C_PLAYER_COUNT_IN_REGION)pParam);
			break;
		case _e_condition.c_29:
			C_29.Write(bw, (C_29)pParam);
			break;
		case _e_condition.c_30:
			C_30.Write(bw, (C_30)pParam);
			break;
		case _e_condition.c_32:
			C_32.Write(bw, (C_32)pParam);
			break;
		case _e_condition.c_34:
			C_34.Write(bw, (C_34)pParam);
			break;
		case _e_condition.c_35:
			C_35.Write(bw, (C_35)pParam);
			break;
		case _e_condition.c_36:
			C_36.Write(bw, (C_36)pParam);
			break;
		case _e_condition.c_37:
			C_37.Write(bw, (C_37)pParam);
			break;
		case _e_condition.c_38:
			C_38.Write(bw, (C_38)pParam);
			break;
		case _e_condition.c_39:
			C_39.Write(bw, (C_39)pParam);
			break;
		case _e_condition.c_start_attack:
		case _e_condition.c_kill_player:
		case _e_condition.c_not:
		case _e_condition.c_or:
		case _e_condition.c_and:
		case _e_condition.c_died:
		case _e_condition.c_plus:
		case _e_condition.c_minus:
		case _e_condition.c_multiply:
		case _e_condition.c_divide:
		case _e_condition.c_great:
		case _e_condition.c_less:
		case _e_condition.c_equ:
		case _e_condition.c_stop_fight:
		case _e_condition.c_room_index:
		case _e_condition.c_31:
		case _e_condition.c_33:
			break;
		}
	}

	public object Copy()
	{
		_s_condition s_condition = new _s_condition();
		s_condition.iType = iType;
		switch (iType)
		{
		case _e_condition.c_time_come:
			s_condition.pParam = (pParam as C_TIME_COME).Copy();
			break;
		case _e_condition.c_hp_less:
			s_condition.pParam = (pParam as C_HP_LESS).Copy();
			break;
		case _e_condition.c_random:
			s_condition.pParam = (pParam as C_RANDOM).Copy();
			break;
		case _e_condition.c_var:
			s_condition.pParam = (pParam as C_VAR).Copy();
			break;
		case _e_condition.c_constant:
			s_condition.pParam = (pParam as C_CONSTANT).Copy();
			break;
		case _e_condition.c_be_hurt:
			s_condition.pParam = (pParam as C_BE_HURT).Copy();
			break;
		case _e_condition.c_reach_end:
			s_condition.pParam = (pParam as C_REACH_END).Copy();
			break;
		case _e_condition.c_at_history_stage:
			s_condition.pParam = (pParam as C_HISTORY_STAGE).Copy();
			break;
		case _e_condition.c_history_value:
			s_condition.pParam = (pParam as C_HISTORY_VALUE).Copy();
			break;
		case _e_condition.c_local_var:
			s_condition.pParam = (pParam as C_LOCAL_VAR).Copy();
			break;
		case _e_condition.c_reach_end_2:
			s_condition.pParam = (pParam as C_REACH_END_2).Copy();
			break;
		case _e_condition.c_has_filter:
			s_condition.pParam = (pParam as C_HAS_FILTER).Copy();
			break;
		case _e_condition.c_player_count_in_radius:
			s_condition.pParam = (pParam as C_PLAYER_COUNT_IN_RADIUS).Copy();
			break;
		case _e_condition.c_player_count_in_region:
			s_condition.pParam = (pParam as C_PLAYER_COUNT_IN_REGION).Copy();
			break;
		case _e_condition.c_29:
			s_condition.pParam = (pParam as C_29).Copy();
			break;
		case _e_condition.c_30:
			s_condition.pParam = (pParam as C_30).Copy();
			break;
		case _e_condition.c_32:
			s_condition.pParam = (pParam as C_32).Copy();
			break;
		case _e_condition.c_34:
			s_condition.pParam = (pParam as C_34).Copy();
			break;
		case _e_condition.c_35:
			s_condition.pParam = (pParam as C_35).Copy();
			break;
		case _e_condition.c_36:
			s_condition.pParam = (pParam as C_36).Copy();
			break;
		case _e_condition.c_37:
			s_condition.pParam = (pParam as C_37).Copy();
			break;
		case _e_condition.c_38:
			s_condition.pParam = (pParam as C_38).Copy();
			break;
		case _e_condition.c_39:
			s_condition.pParam = (pParam as C_39).Copy();
			break;
		}
		return s_condition;
	}

	public bool Search(string str)
	{
		bool result = false;
		switch (iType)
		{
		case _e_condition.c_time_come:
			result = (pParam as C_TIME_COME).Search(str);
			break;
		case _e_condition.c_hp_less:
			result = (pParam as C_HP_LESS).Search(str);
			break;
		case _e_condition.c_random:
			result = (pParam as C_RANDOM).Search(str);
			break;
		case _e_condition.c_var:
			result = (pParam as C_VAR).Search(str);
			break;
		case _e_condition.c_constant:
			result = (pParam as C_CONSTANT).Search(str);
			break;
		case _e_condition.c_be_hurt:
			result = (pParam as C_BE_HURT).Search(str);
			break;
		case _e_condition.c_reach_end:
			result = (pParam as C_REACH_END).Search(str);
			break;
		case _e_condition.c_at_history_stage:
			result = (pParam as C_HISTORY_STAGE).Search(str);
			break;
		case _e_condition.c_history_value:
			result = (pParam as C_HISTORY_VALUE).Search(str);
			break;
		case _e_condition.c_local_var:
			result = (pParam as C_LOCAL_VAR).Search(str);
			break;
		case _e_condition.c_reach_end_2:
			result = (pParam as C_REACH_END_2).Search(str);
			break;
		case _e_condition.c_has_filter:
			result = (pParam as C_HAS_FILTER).Search(str);
			break;
		case _e_condition.c_player_count_in_radius:
			result = (pParam as C_PLAYER_COUNT_IN_RADIUS).Search(str);
			break;
		case _e_condition.c_player_count_in_region:
			result = (pParam as C_PLAYER_COUNT_IN_REGION).Search(str);
			break;
		case _e_condition.c_29:
			result = (pParam as C_29).Search(str);
			break;
		case _e_condition.c_30:
			result = (pParam as C_30).Search(str);
			break;
		case _e_condition.c_32:
			result = (pParam as C_32).Search(str);
			break;
		case _e_condition.c_34:
			result = (pParam as C_34).Search(str);
			break;
		case _e_condition.c_35:
			result = (pParam as C_35).Search(str);
			break;
		case _e_condition.c_36:
			result = (pParam as C_36).Search(str);
			break;
		case _e_condition.c_37:
			result = (pParam as C_37).Search(str);
			break;
		case _e_condition.c_38:
			result = (pParam as C_38).Search(str);
			break;
		case _e_condition.c_39:
			result = (pParam as C_39).Search(str);
			break;
		}
		return result;
	}

	private int GetConditionParamSize(_e_condition type)
	{
		return type switch
		{
			_e_condition.c_time_come => 4, 
			_e_condition.c_hp_less => 4, 
			_e_condition.c_random => 4, 
			_e_condition.c_var => 4, 
			_e_condition.c_constant => 4, 
			_e_condition.c_be_hurt => 8, 
			_e_condition.c_reach_end => 4, 
			_e_condition.c_at_history_stage => 4, 
			_e_condition.c_history_value => 4, 
			_e_condition.c_local_var => 4, 
			_e_condition.c_reach_end_2 => 8, 
			_e_condition.c_has_filter => 4, 
			_e_condition.c_player_count_in_radius => 4, 
			_e_condition.c_player_count_in_region => 24, 
			_e_condition.c_29 => 20, 
			_e_condition.c_30 => 12, 
			_e_condition.c_32 => 8, 
			_e_condition.c_34 => 8, 
			_e_condition.c_35 => 4, 
			_e_condition.c_36 => 24, 
			_e_condition.c_37 => 1, 
			_e_condition.c_38 => 4, 
			_e_condition.c_39 => 12, 
			_ => 0, 
		};
	}
}
