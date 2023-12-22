using System.ComponentModel;
using System.IO;
using AIPolicyEditor.aipolicy.data.Operations;
using System.Windows.Forms;
using System.Security.Principal;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class _s_operation
{
	public enum _e_operation
	{
		o_attact,
		o_use_skill,
		o_talk,
		o_reset_hate_list,
		o_run_trigger,
		o_stop_trigger,
		o_active_trigger,
		o_create_timer,
		o_kill_timer,
		o_flee,
		o_set_hate_to_first,
		o_set_hate_to_last,
		o_set_hate_fifty_percent,
		o_skip_operation,
		o_active_controller,
		o_set_global,
		o_revise_global,
		o_summon_monster,
		o_walk_along,
		o_play_action,
		o_revise_history,
		o_set_history,
		o_deliver_faction_pvp_points,
		o_calc_var,
		o_summon_monster_2,
		o_walk_along_2,
		o_use_skill_2,
		o_active_controller_2,
		o_deliver_task,
		o_summon_mine,
		o_summon_npc,
		o_deliver_random_task_in_region,
		o_deliver_task_in_hate_list,
		o_clear_tower_task_in_region,
		o_save_player_count_in_radius_to_param,
		o_save_player_count_in_region_to_param,
		o_36,
		o_37,
		o_38,
		o_39,
		o_40,
		o_41,
		o_42,
		o_43,
		o_44,
		o_45,
		o_46,
		o_47,
		o_48,
		o_49,
		o_50,
		o_51,
		o_52,
		o_53,
		o_54,
		o_55,
		o_56,
		o_57,
		o_58,
		o_59,
		o_60,
		o_61,
		o_62,
		o_63,
		o_64,
		o_65,
		o_66,
		o_67,
		o_68,
		o_69,
		o_70,
		o_71,
		o_72,
		o_73,
		o_74,
		o_75,
		o_76,
		o_77,
		o_78,
		o_79,
		o_num
	}

	[Browsable(false)]
	public _e_operation iType { get; set; }

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public object pParam { get; set; }

	public _s_target mTarget { get; set; } = new _s_target();


	public void Read(BinaryReader br, int dwVersion, int listPolicy, int listTriggerPtr, int listOperation)
	{
		iType = (_e_operation)br.ReadInt32();
		switch (iType)
		{
		case _e_operation.o_attact:
			pParam = O_ATTACK_TYPE.Read(br);
			break;
		case _e_operation.o_use_skill:
			pParam = O_USE_SKILL.Read(br);
			break;
		case _e_operation.o_talk:
			pParam = O_TALK_TEXT.Read(br, dwVersion);
			break;
		case _e_operation.o_run_trigger:
			pParam = O_RUN_TRIGGER.Read(br);
			break;
		case _e_operation.o_stop_trigger:
			pParam = O_STOP_TRIGGER.Read(br);
			break;
		case _e_operation.o_active_trigger:
			pParam = O_ACTIVE_TRIGGER.Read(br);
			break;
		case _e_operation.o_create_timer:
			pParam = O_CREATE_TIMER.Read(br);
			break;
		case _e_operation.o_kill_timer:
			pParam = O_KILL_TIMER.Read(br);
			break;
		case _e_operation.o_active_controller:
			pParam = O_ACTIVE_CONTROLLER.Read(br, dwVersion);
			break;
		case _e_operation.o_set_global:
			if (dwVersion >= 4)
			{
				pParam = O_SET_GLOBAL.Read(br);
			}
			else
			{
				pParam = O_SET_GLOBAL_VERSION3.Read(br);
			}
			break;
		case _e_operation.o_revise_global:
			pParam = O_REVISE_GLOBAL.Read(br);
			break;
		case _e_operation.o_summon_monster:
			if (dwVersion >= 7)
			{
				pParam = O_SUMMON_MONSTER.Read(br);
			}
			else
			{
				pParam = O_SUMMON_MONSTER_VERSION6.Read(br);
			}
			break;
		case _e_operation.o_walk_along:
			pParam = O_WALK_ALONG.Read(br);
			break;
		case _e_operation.o_play_action:
			if (dwVersion >= 9)
			{
				pParam = O_PLAY_ACTION.Read(br);
			}
			else
			{
				pParam = O_PLAY_ACTION_VERSION8.Read(br);
			}
			break;
		case _e_operation.o_revise_history:
			pParam = O_REVISE_HISTORY.Read(br);
			break;
		case _e_operation.o_set_history:
			pParam = O_SET_HISTORY.Read(br);
			break;
		case _e_operation.o_deliver_faction_pvp_points:
			pParam = O_DELIVER_FACTION_PVP_POINTS.Read(br);
			break;
		case _e_operation.o_calc_var:
			pParam = O_CALC_VAR.Read(br);
			break;
		case _e_operation.o_summon_monster_2:
			pParam = O_SUMMON_MONSTER_2.Read(br);
			break;
		case _e_operation.o_walk_along_2:
			pParam = O_WALK_ALONG_2.Read(br);
			break;
		case _e_operation.o_use_skill_2:
			pParam = O_USE_SKILL_2.Read(br);
			break;
		case _e_operation.o_active_controller_2:
			pParam = O_ACTIVE_CONTROLLER_2.Read(br);
			break;
		case _e_operation.o_deliver_task:
			pParam = O_DELIVER_TASK.Read(br);
			break;
		case _e_operation.o_summon_mine:
			pParam = O_SUMMON_MINE.Read(br, dwVersion);
			break;
		case _e_operation.o_summon_npc:
			pParam = O_SUMMON_NPC.Read(br);
			break;
		case _e_operation.o_deliver_random_task_in_region:
			pParam = O_DELIVER_RANDOM_TASK_IN_REGION.Read(br);
			break;
		case _e_operation.o_deliver_task_in_hate_list:
			pParam = O_DELIVER_TASK_IN_HATE_LIST.Read(br);
			break;
		case _e_operation.o_clear_tower_task_in_region:
			pParam = O_CLEAR_TOWER_TASK_IN_REGION.Read(br);
			break;
		case _e_operation.o_save_player_count_in_radius_to_param:
			pParam = O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM.Read(br);
			break;
		case _e_operation.o_save_player_count_in_region_to_param:
			pParam = O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.Read(br);
			break;
		case _e_operation.o_36:
			pParam = O_36.Read(br);
			break;
		case _e_operation.o_37:
			pParam = O_37.Read(br);
			break;
		case _e_operation.o_38:
			pParam = O_38.Read(br);
			break;
		case _e_operation.o_39:
			pParam = O_39.Read(br);
			break;
		case _e_operation.o_40:
			pParam = O_40.Read(br);
			break;
		case _e_operation.o_41:
			pParam = O_41.Read(br);
			break;
		case _e_operation.o_42:
			pParam = O_42.Read(br);
			break;
		case _e_operation.o_43:
			pParam = O_43.Read(br);
			break;
		case _e_operation.o_44:
			pParam = O_44.Read(br);
			break;
		case _e_operation.o_45:
			pParam = O_45.Read(br);
			break;
		case _e_operation.o_46:
			pParam = O_46.Read(br);
			break;
		case _e_operation.o_47:
			pParam = O_47.Read(br);
			break;
		case _e_operation.o_48:
			pParam = O_48.Read(br);
			break;
		case _e_operation.o_49:
			pParam = O_49.Read(br);
			break;
		case _e_operation.o_50:
			pParam = O_50.Read(br);
			break;
		case _e_operation.o_51:
			pParam = O_51.Read(br);
			break;
		case _e_operation.o_52:
			pParam = O_52.Read(br);
			break;
		case _e_operation.o_53:
			pParam = O_53.Read(br);
			break;
		case _e_operation.o_54:
			pParam = O_54.Read(br);
			break;
		case _e_operation.o_55:
			pParam = O_55.Read(br);
			break;
		case _e_operation.o_56:
			pParam = O_56.Read(br);
			break;
		case _e_operation.o_57:
			pParam = O_57.Read(br);
			break;
		case _e_operation.o_58:
			pParam = O_58.Read(br);
			break;
		case _e_operation.o_59:
			pParam = O_59.Read(br);
			break;
		case _e_operation.o_60:
			pParam = O_60.Read(br);
			break;
		case _e_operation.o_61:
			pParam = O_61.Read(br);
			break;
		case _e_operation.o_63:
			pParam = O_63.Read(br);
			break;
		case _e_operation.o_64:
			pParam = O_64.Read(br);
			break;
		case _e_operation.o_65:
			pParam = O_65.Read(br);
			break;
		case _e_operation.o_66:
			pParam = O_66.Read(br);
			break;
		case _e_operation.o_67:
			pParam = O_67.Read(br);
			break;
		case _e_operation.o_68:
			pParam = O_68.Read(br);
			break;
		case _e_operation.o_69:
			pParam = O_69.Read(br);
			break;
		case _e_operation.o_70:
			pParam = O_70.Read(br);
			break;
		case _e_operation.o_71:
			pParam = O_71.Read(br);
			break;
		case _e_operation.o_72:
			pParam = O_72.Read(br);
			break;
		case _e_operation.o_73:
			pParam = O_73.Read(br);
			break;
		case _e_operation.o_74:
			pParam = O_74.Read(br);
			break;
		case _e_operation.o_75:
			pParam = O_75.Read(br);
			break;
		case _e_operation.o_76:
			pParam = O_76.Read(br);
			break;
		case _e_operation.o_77:
			pParam = O_77.Read(br);
			break;
		case _e_operation.o_78:
			pParam = O_78.Read(br);
			break;
		case _e_operation.o_79:
			pParam = O_79.Read(br);
			break;

		default:
			if ((int)iType == 100)
			{
				pParam = br.ReadBytes(8);
				break;
			}

			if ((int)iType == 97)
			{
				pParam = null;
				break;
			}

			if ((int)iType == 98)
			{
				pParam = br.ReadBytes(4);
				break;
			}

			if ((int)iType == 99)
			{
				pParam = br.ReadBytes(80);
				break;
			}

			if ((int)iType == 95)
			{
				pParam = br.ReadBytes(1);
				break;
			}

			if ((int)iType == 92)
			{
				pParam = br.ReadBytes(36);
				break;
			}

			if ((int)iType == 85)
			{
				pParam = br.ReadBytes(28);
				break;
			}

			if ((int)iType == 86)
			{
				pParam = br.ReadBytes(12);
				break;
			}

			if ((int)iType == 89)
			{
				pParam = br.ReadBytes(40);
				break;
			}

			if ((int)iType == 83)
			{
				pParam = br.ReadBytes(44);
				break;
			}

			if ((int)iType == 81 || (int)iType == 80)
			{
				pParam = br.ReadBytes(24);
				break;
			}

			if ((int)iType == 84)
			{
				pParam = null;
				break;
			}

			if ((int)iType == 87)
			{
				pParam = br.ReadBytes(44);
				break;
			}

			if ((int)iType == 88)
			{
				pParam = br.ReadBytes(12);
				break;
			}

			if ((int)iType == 82)
			{
				pParam = br.ReadBytes(28);
				break;
			}

			if ((int)iType == 94)
			{
				pParam = br.ReadBytes(1);
				break;
			}

			if ((int)iType == 90)
			{
				pParam = br.ReadBytes(16);
				break;
			}

			if ((int)iType == 93)
			{
				pParam = br.ReadBytes(40);
				break;
			}

			if ((int)iType == 91)
			{
				pParam = br.ReadBytes(24);
				break;
			}

			if ((int)iType == 96)
			{
				pParam = br.ReadBytes(8);
				break;
			}

			if ((int)iType == 62)
			{
				pParam = br.ReadBytes(12); //8 or 12
				break;
			}

			if ((int)iType == 101)
			{
				pParam = br.ReadBytes(8);
				break;
			}

			if ((int)iType == 102)
			{
				pParam = br.ReadBytes(8);
				break;
			}

			if (iType >= _e_operation.o_num)
			{
				throw new System.InvalidOperationException("Unknown operation " + iType + ":" + (int)iType + " (" + (br.BaseStream.Position-4) + ")");
			}

			break;
		}

		mTarget.Read(br, dwVersion, listPolicy, listTriggerPtr, listOperation);
	}

	public void Write(BinaryWriter bw, int dwVersion)
	{
		bw.Write((int)iType);
		switch (iType)
		{
		case _e_operation.o_attact:
			O_ATTACK_TYPE.Write(bw, (O_ATTACK_TYPE)pParam);
			break;
		case _e_operation.o_use_skill:
			O_USE_SKILL.Write(bw, (O_USE_SKILL)pParam);
			break;
		case _e_operation.o_talk:
			O_TALK_TEXT.Write(bw, (O_TALK_TEXT)pParam, dwVersion);
			break;
		case _e_operation.o_run_trigger:
			O_RUN_TRIGGER.Write(bw, (O_RUN_TRIGGER)pParam);
			break;
		case _e_operation.o_stop_trigger:
			O_STOP_TRIGGER.Write(bw, (O_STOP_TRIGGER)pParam);
			break;
		case _e_operation.o_active_trigger:
			O_ACTIVE_TRIGGER.Write(bw, (O_ACTIVE_TRIGGER)pParam);
			break;
		case _e_operation.o_create_timer:
			O_CREATE_TIMER.Write(bw, (O_CREATE_TIMER)pParam);
			break;
		case _e_operation.o_kill_timer:
			O_KILL_TIMER.Write(bw, (O_KILL_TIMER)pParam);
			break;
		case _e_operation.o_active_controller:
			O_ACTIVE_CONTROLLER.Write(bw, (O_ACTIVE_CONTROLLER)pParam, dwVersion);
			break;
		case _e_operation.o_set_global:
			if (dwVersion >= 4)
			{
				O_SET_GLOBAL.Write(bw, (O_SET_GLOBAL)pParam);
			}
			else
			{
				O_SET_GLOBAL_VERSION3.Write(bw, (O_SET_GLOBAL_VERSION3)pParam);
			}
			break;
		case _e_operation.o_revise_global:
			O_REVISE_GLOBAL.Write(bw, (O_REVISE_GLOBAL)pParam);
			break;
		case _e_operation.o_summon_monster:
			if (dwVersion >= 7)
			{
				O_SUMMON_MONSTER.Write(bw, (O_SUMMON_MONSTER)pParam);
			}
			else
			{
				O_SUMMON_MONSTER_VERSION6.Write(bw, (O_SUMMON_MONSTER_VERSION6)pParam);
			}
			break;
		case _e_operation.o_walk_along:
			O_WALK_ALONG.Write(bw, (O_WALK_ALONG)pParam);
			break;
		case _e_operation.o_play_action:
			if (dwVersion >= 9)
			{
				O_PLAY_ACTION.Write(bw, (O_PLAY_ACTION)pParam);
			}
			else
			{
				O_PLAY_ACTION_VERSION8.Write(bw, (O_PLAY_ACTION_VERSION8)pParam);
			}
			break;
		case _e_operation.o_revise_history:
			O_REVISE_HISTORY.Write(bw, (O_REVISE_HISTORY)pParam);
			break;
		case _e_operation.o_set_history:
			O_SET_HISTORY.Write(bw, (O_SET_HISTORY)pParam);
			break;
		case _e_operation.o_deliver_faction_pvp_points:
			O_DELIVER_FACTION_PVP_POINTS.Write(bw, (O_DELIVER_FACTION_PVP_POINTS)pParam);
			break;
		case _e_operation.o_calc_var:
			O_CALC_VAR.Write(bw, (O_CALC_VAR)pParam);
			break;
		case _e_operation.o_summon_monster_2:
			O_SUMMON_MONSTER_2.Write(bw, (O_SUMMON_MONSTER_2)pParam);
			break;
		case _e_operation.o_walk_along_2:
			O_WALK_ALONG_2.Write(bw, (O_WALK_ALONG_2)pParam);
			break;
		case _e_operation.o_use_skill_2:
			O_USE_SKILL_2.Write(bw, (O_USE_SKILL_2)pParam);
			break;
		case _e_operation.o_active_controller_2:
			O_ACTIVE_CONTROLLER_2.Write(bw, (O_ACTIVE_CONTROLLER_2)pParam);
			break;
		case _e_operation.o_deliver_task:
			O_DELIVER_TASK.Write(bw, (O_DELIVER_TASK)pParam);
			break;
		case _e_operation.o_summon_mine:
			O_SUMMON_MINE.Write(bw, (O_SUMMON_MINE)pParam, dwVersion);
			break;
		case _e_operation.o_summon_npc:
			O_SUMMON_NPC.Write(bw, (O_SUMMON_NPC)pParam);
			break;
		case _e_operation.o_deliver_random_task_in_region:
			O_DELIVER_RANDOM_TASK_IN_REGION.Write(bw, (O_DELIVER_RANDOM_TASK_IN_REGION)pParam);
			break;
		case _e_operation.o_deliver_task_in_hate_list:
			O_DELIVER_TASK_IN_HATE_LIST.Write(bw, (O_DELIVER_TASK_IN_HATE_LIST)pParam);
			break;
		case _e_operation.o_clear_tower_task_in_region:
			O_CLEAR_TOWER_TASK_IN_REGION.Write(bw, (O_CLEAR_TOWER_TASK_IN_REGION)pParam);
			break;
		case _e_operation.o_save_player_count_in_radius_to_param:
			O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM.Write(bw, (O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM)pParam);
			break;
		case _e_operation.o_save_player_count_in_region_to_param:
			O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM.Write(bw, (O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM)pParam);
			break;
		case _e_operation.o_36:
			O_36.Write(bw, (O_36)pParam);
			break;
		case _e_operation.o_37:
			O_37.Write(bw, (O_37)pParam);
			break;
		case _e_operation.o_38:
			O_38.Write(bw, (O_38)pParam);
			break;
		case _e_operation.o_39:
			O_39.Write(bw, (O_39)pParam);
			break;
		case _e_operation.o_40:
			O_40.Write(bw, (O_40)pParam);
			break;
		case _e_operation.o_41:
			O_41.Write(bw, (O_41)pParam);
			break;
		case _e_operation.o_42:
			O_42.Write(bw, (O_42)pParam);
			break;
		case _e_operation.o_43:
			O_43.Write(bw, (O_43)pParam);
			break;
		case _e_operation.o_44:
			O_44.Write(bw, (O_44)pParam);
			break;
		case _e_operation.o_45:
			O_45.Write(bw, (O_45)pParam);
			break;
		case _e_operation.o_46:
			O_46.Write(bw, (O_46)pParam);
			break;
		case _e_operation.o_47:
			O_47.Write(bw, (O_47)pParam);
			break;
		case _e_operation.o_48:
			O_48.Write(bw, (O_48)pParam);
			break;
		case _e_operation.o_49:
			O_49.Write(bw, (O_49)pParam);
			break;
		case _e_operation.o_50:
			O_50.Write(bw, (O_50)pParam);
			break;
		case _e_operation.o_51:
			O_51.Write(bw, (O_51)pParam);
			break;
		case _e_operation.o_52:
			O_52.Write(bw, (O_52)pParam);
			break;
		case _e_operation.o_53:
			O_53.Write(bw, (O_53)pParam);
			break;
		case _e_operation.o_54:
			O_54.Write(bw, (O_54)pParam);
			break;
		case _e_operation.o_55:
			O_55.Write(bw, (O_55)pParam);
			break;
		case _e_operation.o_56:
			O_56.Write(bw, (O_56)pParam);
			break;
		case _e_operation.o_57:
			O_57.Write(bw, (O_57)pParam);
			break;
		case _e_operation.o_58:
			O_58.Write(bw, (O_58)pParam);
			break;
		case _e_operation.o_59:
			O_59.Write(bw, (O_59)pParam);
			break;
		case _e_operation.o_60:
			O_60.Write(bw, (O_60)pParam);
			break;
		case _e_operation.o_61:
			O_61.Write(bw, (O_61)pParam);
			break;
		case _e_operation.o_63:
			O_63.Write(bw, (O_63)pParam);
			break;
		case _e_operation.o_64:
			O_64.Write(bw, (O_64)pParam);
			break;
		case _e_operation.o_65:
			O_65.Write(bw, (O_65)pParam);
			break;
		case _e_operation.o_66:
			O_66.Write(bw, (O_66)pParam);
			break;
		case _e_operation.o_67:
			O_67.Write(bw, (O_67)pParam);
			break;
		case _e_operation.o_68:
			O_68.Write(bw, (O_68)pParam);
			break;
		case _e_operation.o_69:
			O_69.Write(bw, (O_69)pParam);
			break;
		case _e_operation.o_70:
			O_70.Write(bw, (O_70)pParam);
			break;
		case _e_operation.o_71:
			O_71.Write(bw, (O_71)pParam);
			break;
		case _e_operation.o_72:
			O_72.Write(bw, (O_72)pParam);
			break;
		case _e_operation.o_73:
			O_73.Write(bw, (O_73)pParam);
			break;
		case _e_operation.o_74:
			O_74.Write(bw, (O_74)pParam);
			break;
		case _e_operation.o_75:
			O_75.Write(bw, (O_75)pParam);
			break;
		case _e_operation.o_76:
			O_76.Write(bw, (O_76)pParam);
			break;
		case _e_operation.o_77:
			O_77.Write(bw, (O_77)pParam);
			break;
		case _e_operation.o_78:
			O_78.Write(bw, (O_78)pParam);
			break;
		case _e_operation.o_79:
			O_79.Write(bw, (O_79)pParam);
			break;
		}
		mTarget.Write(bw);
	}

	public object Copy(int dwVersion)
	{
		_s_operation s_operation = new _s_operation();
		s_operation.iType = iType;
		switch (iType)
		{
		case _e_operation.o_attact:
			s_operation.pParam = (pParam as O_ATTACK_TYPE).Copy();
			break;
		case _e_operation.o_use_skill:
			s_operation.pParam = (pParam as O_USE_SKILL).Copy();
			break;
		case _e_operation.o_talk:
			s_operation.pParam = (pParam as O_TALK_TEXT).Copy();
			break;
		case _e_operation.o_run_trigger:
			s_operation.pParam = (pParam as O_RUN_TRIGGER).Copy();
			break;
		case _e_operation.o_stop_trigger:
			s_operation.pParam = (pParam as O_STOP_TRIGGER).Copy();
			break;
		case _e_operation.o_active_trigger:
			s_operation.pParam = (pParam as O_ACTIVE_TRIGGER).Copy();
			break;
		case _e_operation.o_create_timer:
			s_operation.pParam = (pParam as O_CREATE_TIMER).Copy();
			break;
		case _e_operation.o_kill_timer:
			s_operation.pParam = (pParam as O_KILL_TIMER).Copy();
			break;
		case _e_operation.o_active_controller:
			s_operation.pParam = (pParam as O_ACTIVE_CONTROLLER).Copy();
			break;
		case _e_operation.o_set_global:
			if (dwVersion >= 4)
			{
				s_operation.pParam = (pParam as O_SET_GLOBAL).Copy();
			}
			else
			{
				s_operation.pParam = (pParam as O_SET_GLOBAL_VERSION3).Copy();
			}
			break;
		case _e_operation.o_revise_global:
			s_operation.pParam = (pParam as O_REVISE_GLOBAL).Copy();
			break;
		case _e_operation.o_summon_monster:
			if (dwVersion >= 7)
			{
				s_operation.pParam = (pParam as O_SUMMON_MONSTER).Copy();
			}
			else
			{
				s_operation.pParam = (pParam as O_SUMMON_MONSTER_VERSION6).Copy();
			}
			break;
		case _e_operation.o_walk_along:
			s_operation.pParam = (pParam as O_WALK_ALONG).Copy();
			break;
		case _e_operation.o_play_action:
			if (dwVersion >= 9)
			{
				s_operation.pParam = (pParam as O_PLAY_ACTION).Copy();
			}
			else
			{
				s_operation.pParam = (pParam as O_PLAY_ACTION_VERSION8).Copy();
			}
			break;
		case _e_operation.o_revise_history:
			s_operation.pParam = (pParam as O_REVISE_HISTORY).Copy();
			break;
		case _e_operation.o_set_history:
			s_operation.pParam = (pParam as O_SET_HISTORY).Copy();
			break;
		case _e_operation.o_deliver_faction_pvp_points:
			s_operation.pParam = (pParam as O_DELIVER_FACTION_PVP_POINTS).Copy();
			break;
		case _e_operation.o_calc_var:
			s_operation.pParam = (pParam as O_CALC_VAR).Copy();
			break;
		case _e_operation.o_summon_monster_2:
			s_operation.pParam = (pParam as O_SUMMON_MONSTER_2).Copy();
			break;
		case _e_operation.o_walk_along_2:
			s_operation.pParam = (pParam as O_WALK_ALONG_2).Copy();
			break;
		case _e_operation.o_use_skill_2:
			s_operation.pParam = (pParam as O_USE_SKILL_2).Copy();
			break;
		case _e_operation.o_active_controller_2:
			s_operation.pParam = (pParam as O_ACTIVE_CONTROLLER_2).Copy();
			break;
		case _e_operation.o_deliver_task:
			s_operation.pParam = (pParam as O_DELIVER_TASK).Copy();
			break;
		case _e_operation.o_summon_mine:
			s_operation.pParam = (pParam as O_SUMMON_MINE).Copy();
			break;
		case _e_operation.o_summon_npc:
			s_operation.pParam = (pParam as O_SUMMON_NPC).Copy();
			break;
		case _e_operation.o_deliver_random_task_in_region:
			s_operation.pParam = (pParam as O_DELIVER_RANDOM_TASK_IN_REGION).Copy();
			break;
		case _e_operation.o_deliver_task_in_hate_list:
			s_operation.pParam = (pParam as O_DELIVER_TASK_IN_HATE_LIST).Copy();
			break;
		case _e_operation.o_clear_tower_task_in_region:
			s_operation.pParam = (pParam as O_CLEAR_TOWER_TASK_IN_REGION).Copy();
			break;
		case _e_operation.o_save_player_count_in_radius_to_param:
			s_operation.pParam = (pParam as O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM).Copy();
			break;
		case _e_operation.o_save_player_count_in_region_to_param:
			s_operation.pParam = (pParam as O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM).Copy();
			break;
		case _e_operation.o_36:
			s_operation.pParam = (pParam as O_36).Copy();
			break;
		case _e_operation.o_37:
			s_operation.pParam = (pParam as O_37).Copy();
			break;
		case _e_operation.o_38:
			s_operation.pParam = (pParam as O_38).Copy();
			break;
		case _e_operation.o_39:
			s_operation.pParam = (pParam as O_39).Copy();
			break;
		case _e_operation.o_40:
			s_operation.pParam = (pParam as O_40).Copy();
			break;
		case _e_operation.o_41:
			s_operation.pParam = (pParam as O_41).Copy();
			break;
		case _e_operation.o_42:
			s_operation.pParam = (pParam as O_42).Copy();
			break;
		case _e_operation.o_43:
			s_operation.pParam = (pParam as O_43).Copy();
			break;
		case _e_operation.o_44:
			s_operation.pParam = (pParam as O_44).Copy();
			break;
		case _e_operation.o_45:
			s_operation.pParam = (pParam as O_45).Copy();
			break;
		case _e_operation.o_46:
			s_operation.pParam = (pParam as O_46).Copy();
			break;
		case _e_operation.o_47:
			s_operation.pParam = (pParam as O_47).Copy();
			break;
		case _e_operation.o_48:
			s_operation.pParam = (pParam as O_48).Copy();
			break;
		case _e_operation.o_49:
			s_operation.pParam = (pParam as O_49).Copy();
			break;
		case _e_operation.o_50:
			s_operation.pParam = (pParam as O_50).Copy();
			break;
		case _e_operation.o_51:
			s_operation.pParam = (pParam as O_51).Copy();
			break;
		case _e_operation.o_52:
			s_operation.pParam = (pParam as O_52).Copy();
			break;
		case _e_operation.o_53:
			s_operation.pParam = (pParam as O_53).Copy();
			break;
		case _e_operation.o_54:
			s_operation.pParam = (pParam as O_54).Copy();
			break;
		case _e_operation.o_55:
			s_operation.pParam = (pParam as O_55).Copy();
			break;
		case _e_operation.o_56:
			s_operation.pParam = (pParam as O_56).Copy();
			break;
		case _e_operation.o_57:
			s_operation.pParam = (pParam as O_57).Copy();
			break;
		case _e_operation.o_58:
			s_operation.pParam = (pParam as O_58).Copy();
			break;
		case _e_operation.o_59:
			s_operation.pParam = (pParam as O_59).Copy();
			break;
		case _e_operation.o_60:
			s_operation.pParam = (pParam as O_60).Copy();
			break;
		case _e_operation.o_61:
			s_operation.pParam = (pParam as O_61).Copy();
			break;
		case _e_operation.o_63:
			s_operation.pParam = (pParam as O_63).Copy();
			break;
		case _e_operation.o_64:
			s_operation.pParam = (pParam as O_64).Copy();
			break;
		case _e_operation.o_65:
			s_operation.pParam = (pParam as O_65).Copy();
			break;
		case _e_operation.o_66:
			s_operation.pParam = (pParam as O_66).Copy();
			break;
		case _e_operation.o_67:
			s_operation.pParam = (pParam as O_67).Copy();
			break;
		case _e_operation.o_68:
			s_operation.pParam = (pParam as O_68).Copy();
			break;
		case _e_operation.o_69:
			s_operation.pParam = (pParam as O_69).Copy();
			break;
		case _e_operation.o_70:
			s_operation.pParam = (pParam as O_70).Copy();
			break;
		case _e_operation.o_71:
			s_operation.pParam = (pParam as O_71).Copy();
			break;
		case _e_operation.o_72:
			s_operation.pParam = (pParam as O_72).Copy();
			break;
		case _e_operation.o_73:
			s_operation.pParam = (pParam as O_73).Copy();
			break;
		case _e_operation.o_74:
			s_operation.pParam = (pParam as O_74).Copy();
			break;
		case _e_operation.o_75:
			s_operation.pParam = (pParam as O_75).Copy();
			break;
		case _e_operation.o_76:
			s_operation.pParam = (pParam as O_76).Copy();
			break;
		case _e_operation.o_77:
			s_operation.pParam = (pParam as O_77).Copy();
			break;
		case _e_operation.o_78:
			s_operation.pParam = (pParam as O_78).Copy();
			break;
		case _e_operation.o_79:
			s_operation.pParam = (pParam as O_79).Copy();
			break;
		}
		s_operation.mTarget = mTarget.Copy() as _s_target;
		return s_operation;
	}

	public bool Search(string str, int dwVersion)
	{
		bool flag = false;
		switch (iType)
		{
		case _e_operation.o_attact:
			flag = (pParam as O_ATTACK_TYPE).Search(str);
			break;
		case _e_operation.o_use_skill:
			flag = (pParam as O_USE_SKILL).Search(str);
			break;
		case _e_operation.o_talk:
			flag = (pParam as O_TALK_TEXT).Search(str);
			break;
		case _e_operation.o_run_trigger:
			flag = (pParam as O_RUN_TRIGGER).Search(str);
			break;
		case _e_operation.o_stop_trigger:
			flag = (pParam as O_STOP_TRIGGER).Search(str);
			break;
		case _e_operation.o_active_trigger:
			flag = (pParam as O_ACTIVE_TRIGGER).Search(str);
			break;
		case _e_operation.o_create_timer:
			flag = (pParam as O_CREATE_TIMER).Search(str);
			break;
		case _e_operation.o_kill_timer:
			flag = (pParam as O_KILL_TIMER).Search(str);
			break;
		case _e_operation.o_active_controller:
			flag = (pParam as O_ACTIVE_CONTROLLER).Search(str);
			break;
		case _e_operation.o_set_global:
			flag = ((dwVersion < 4) ? (pParam as O_SET_GLOBAL_VERSION3).Search(str) : (pParam as O_SET_GLOBAL).Search(str));
			break;
		case _e_operation.o_revise_global:
			flag = (pParam as O_REVISE_GLOBAL).Search(str);
			break;
		case _e_operation.o_summon_monster:
			flag = ((dwVersion < 7) ? (pParam as O_SUMMON_MONSTER_VERSION6).Search(str) : (pParam as O_SUMMON_MONSTER).Search(str));
			break;
		case _e_operation.o_walk_along:
			flag = (pParam as O_WALK_ALONG).Search(str);
			break;
		case _e_operation.o_play_action:
			flag = ((dwVersion < 9) ? (pParam as O_PLAY_ACTION_VERSION8).Search(str) : (pParam as O_PLAY_ACTION).Search(str));
			break;
		case _e_operation.o_revise_history:
			flag = (pParam as O_REVISE_HISTORY).Search(str);
			break;
		case _e_operation.o_set_history:
			flag = (pParam as O_SET_HISTORY).Search(str);
			break;
		case _e_operation.o_deliver_faction_pvp_points:
			flag = (pParam as O_DELIVER_FACTION_PVP_POINTS).Search(str);
			break;
		case _e_operation.o_calc_var:
			flag = (pParam as O_CALC_VAR).Search(str);
			break;
		case _e_operation.o_summon_monster_2:
			flag = (pParam as O_SUMMON_MONSTER_2).Search(str);
			break;
		case _e_operation.o_walk_along_2:
			flag = (pParam as O_WALK_ALONG_2).Search(str);
			break;
		case _e_operation.o_use_skill_2:
			flag = (pParam as O_USE_SKILL_2).Search(str);
			break;
		case _e_operation.o_active_controller_2:
			flag = (pParam as O_ACTIVE_CONTROLLER_2).Search(str);
			break;
		case _e_operation.o_deliver_task:
			flag = (pParam as O_DELIVER_TASK).Search(str);
			break;
		case _e_operation.o_summon_mine:
			flag = (pParam as O_SUMMON_MINE).Search(str);
			break;
		case _e_operation.o_summon_npc:
			flag = (pParam as O_SUMMON_NPC).Search(str);
			break;
		case _e_operation.o_deliver_random_task_in_region:
			flag = (pParam as O_DELIVER_RANDOM_TASK_IN_REGION).Search(str);
			break;
		case _e_operation.o_deliver_task_in_hate_list:
			flag = (pParam as O_DELIVER_TASK_IN_HATE_LIST).Search(str);
			break;
		case _e_operation.o_clear_tower_task_in_region:
			flag = (pParam as O_CLEAR_TOWER_TASK_IN_REGION).Search(str);
			break;
		case _e_operation.o_save_player_count_in_radius_to_param:
			flag = (pParam as O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM).Search(str);
			break;
		case _e_operation.o_save_player_count_in_region_to_param:
			flag = (pParam as O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM).Search(str);
			break;
		case _e_operation.o_36:
			flag = (pParam as O_36).Search(str);
			break;
		case _e_operation.o_37:
			flag = (pParam as O_37).Search(str);
			break;
		case _e_operation.o_38:
			flag = (pParam as O_38).Search(str);
			break;
		case _e_operation.o_39:
			flag = (pParam as O_39).Search(str);
			break;
		case _e_operation.o_40:
			flag = (pParam as O_40).Search(str);
			break;
		case _e_operation.o_41:
			flag = (pParam as O_41).Search(str);
			break;
		case _e_operation.o_42:
			flag = (pParam as O_42).Search(str);
			break;
		case _e_operation.o_43:
			flag = (pParam as O_43).Search(str);
			break;
		case _e_operation.o_44:
			flag = (pParam as O_44).Search(str);
			break;
		case _e_operation.o_45:
			flag = (pParam as O_45).Search(str);
			break;
		case _e_operation.o_46:
			flag = (pParam as O_46).Search(str);
			break;
		case _e_operation.o_47:
			flag = (pParam as O_47).Search(str);
			break;
		case _e_operation.o_48:
			flag = (pParam as O_48).Search(str);
			break;
		case _e_operation.o_49:
			flag = (pParam as O_49).Search(str);
			break;
		case _e_operation.o_50:
			flag = (pParam as O_50).Search(str);
			break;
		case _e_operation.o_51:
			flag = (pParam as O_51).Search(str);
			break;
		case _e_operation.o_52:
			flag = (pParam as O_52).Search(str);
			break;
		case _e_operation.o_53:
			flag = (pParam as O_53).Search(str);
			break;
		case _e_operation.o_54:
			flag = (pParam as O_54).Search(str);
			break;
		case _e_operation.o_55:
			flag = (pParam as O_55).Search(str);
			break;
		case _e_operation.o_56:
			flag = (pParam as O_56).Search(str);
			break;
		case _e_operation.o_57:
			flag = (pParam as O_57).Search(str);
			break;
		case _e_operation.o_58:
			flag = (pParam as O_58).Search(str);
			break;
		case _e_operation.o_59:
			flag = (pParam as O_59).Search(str);
			break;
		case _e_operation.o_60:
			flag = (pParam as O_60).Search(str);
			break;
		case _e_operation.o_61:
			flag = (pParam as O_61).Search(str);
			break;
		case _e_operation.o_63:
			flag = (pParam as O_63).Search(str);
			break;
		case _e_operation.o_64:
			flag = (pParam as O_64).Search(str);
			break;
		case _e_operation.o_65:
			flag = (pParam as O_65).Search(str);
			break;
		case _e_operation.o_66:
			flag = (pParam as O_66).Search(str);
			break;
		case _e_operation.o_67:
			flag = (pParam as O_67).Search(str);
			break;
		case _e_operation.o_68:
			flag = (pParam as O_68).Search(str);
			break;
		case _e_operation.o_69:
			flag = (pParam as O_69).Search(str);
			break;
		case _e_operation.o_70:
			flag = (pParam as O_70).Search(str);
			break;
		case _e_operation.o_71:
			flag = (pParam as O_71).Search(str);
			break;
		case _e_operation.o_72:
			flag = (pParam as O_72).Search(str);
			break;
		case _e_operation.o_73:
			flag = (pParam as O_73).Search(str);
			break;
		case _e_operation.o_74:
			flag = (pParam as O_74).Search(str);
			break;
		case _e_operation.o_75:
			flag = (pParam as O_75).Search(str);
			break;
		case _e_operation.o_76:
			flag = (pParam as O_76).Search(str);
			break;
		case _e_operation.o_77:
			flag = (pParam as O_77).Search(str);
			break;
		case _e_operation.o_78:
			flag = (pParam as O_78).Search(str);
			break;
		case _e_operation.o_79:
			flag = (pParam as O_79).Search(str);
			break;
		}
		if (!flag)
		{
			flag = mTarget.Search(str);
		}
		return flag;
	}
}
