using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using AIPolicyEditor.aipolicy.data;

namespace AIPolicyEditor;

public class SearchWindow : Form
{
	private MainWindow MW;

	public CPolicyDataManager AIPolicy;

	private List<int[]> results = new List<int[]>();

	private List<int[]> results_indexes = new List<int[]>();

	private IContainer components;

	private ListBox listBox_Result;

	private TextBox textBox_Value;

	private Button button_Search;

	private ComboBox comboBox_Type1;

	private ComboBox comboBox_Type2;

	private Button button_SearchByType;

	public SearchWindow(MainWindow mw)
	{
		InitializeComponent();
		MW = mw;
		comboBox_Type1.SelectedIndex = 0;
	}

	private void comboBox_Type1_SelectedIndexChanged(object sender, EventArgs e)
	{
		comboBox_Type2.Items.Clear();
		if (comboBox_Type1.SelectedIndex == 0)
		{
			comboBox_Type2.Items.AddRange(new object[41]
			{
				_s_condition._e_condition.c_time_come,
				_s_condition._e_condition.c_hp_less,
				_s_condition._e_condition.c_start_attack,
				_s_condition._e_condition.c_random,
				_s_condition._e_condition.c_kill_player,
				_s_condition._e_condition.c_not,
				_s_condition._e_condition.c_or,
				_s_condition._e_condition.c_and,
				_s_condition._e_condition.c_died,
				_s_condition._e_condition.c_plus,
				_s_condition._e_condition.c_minus,
				_s_condition._e_condition.c_multiply,
				_s_condition._e_condition.c_divide,
				_s_condition._e_condition.c_great,
				_s_condition._e_condition.c_less,
				_s_condition._e_condition.c_equ,
				_s_condition._e_condition.c_var,
				_s_condition._e_condition.c_constant,
				_s_condition._e_condition.c_be_hurt,
				_s_condition._e_condition.c_reach_end,
				_s_condition._e_condition.c_at_history_stage,
				_s_condition._e_condition.c_history_value,
				_s_condition._e_condition.c_stop_fight,
				_s_condition._e_condition.c_local_var,
				_s_condition._e_condition.c_reach_end_2,
				_s_condition._e_condition.c_has_filter,
				_s_condition._e_condition.c_room_index,
				_s_condition._e_condition.c_player_count_in_radius,
				_s_condition._e_condition.c_player_count_in_region,
				_s_condition._e_condition.c_29,
				_s_condition._e_condition.c_30,
				_s_condition._e_condition.c_31,
				_s_condition._e_condition.c_32,
				_s_condition._e_condition.c_33,
				_s_condition._e_condition.c_34,
				_s_condition._e_condition.c_35,
				_s_condition._e_condition.c_36,
				_s_condition._e_condition.c_37,
				_s_condition._e_condition.c_38,
				_s_condition._e_condition.c_39,
				_s_condition._e_condition.c_40
			});
			comboBox_Type2.SelectedIndex = 0;
		}
		else if (comboBox_Type1.SelectedIndex == 1)
		{
			comboBox_Type2.Items.AddRange(new object[80]
			{
				_s_operation._e_operation.o_attact,
				_s_operation._e_operation.o_use_skill,
				_s_operation._e_operation.o_talk,
				_s_operation._e_operation.o_reset_hate_list,
				_s_operation._e_operation.o_run_trigger,
				_s_operation._e_operation.o_stop_trigger,
				_s_operation._e_operation.o_active_trigger,
				_s_operation._e_operation.o_create_timer,
				_s_operation._e_operation.o_kill_timer,
				_s_operation._e_operation.o_flee,
				_s_operation._e_operation.o_set_hate_to_first,
				_s_operation._e_operation.o_set_hate_to_last,
				_s_operation._e_operation.o_set_hate_fifty_percent,
				_s_operation._e_operation.o_skip_operation,
				_s_operation._e_operation.o_active_controller,
				_s_operation._e_operation.o_set_global,
				_s_operation._e_operation.o_revise_global,
				_s_operation._e_operation.o_summon_monster,
				_s_operation._e_operation.o_walk_along,
				_s_operation._e_operation.o_play_action,
				_s_operation._e_operation.o_revise_history,
				_s_operation._e_operation.o_set_history,
				_s_operation._e_operation.o_deliver_faction_pvp_points,
				_s_operation._e_operation.o_calc_var,
				_s_operation._e_operation.o_summon_monster_2,
				_s_operation._e_operation.o_walk_along_2,
				_s_operation._e_operation.o_use_skill_2,
				_s_operation._e_operation.o_active_controller_2,
				_s_operation._e_operation.o_deliver_task,
				_s_operation._e_operation.o_summon_mine,
				_s_operation._e_operation.o_summon_npc,
				_s_operation._e_operation.o_deliver_random_task_in_region,
				_s_operation._e_operation.o_deliver_task_in_hate_list,
				_s_operation._e_operation.o_clear_tower_task_in_region,
				_s_operation._e_operation.o_save_player_count_in_radius_to_param,
				_s_operation._e_operation.o_save_player_count_in_region_to_param,
				_s_operation._e_operation.o_36,
				_s_operation._e_operation.o_37,
				_s_operation._e_operation.o_38,
				_s_operation._e_operation.o_39,
				_s_operation._e_operation.o_40,
				_s_operation._e_operation.o_41,
				_s_operation._e_operation.o_42,
				_s_operation._e_operation.o_43,
				_s_operation._e_operation.o_44,
				_s_operation._e_operation.o_45,
				_s_operation._e_operation.o_46,
				_s_operation._e_operation.o_47,
				_s_operation._e_operation.o_48,
				_s_operation._e_operation.o_49,
				_s_operation._e_operation.o_50,
				_s_operation._e_operation.o_51,
				_s_operation._e_operation.o_52,
				_s_operation._e_operation.o_53,
				_s_operation._e_operation.o_54,
				_s_operation._e_operation.o_55,
				_s_operation._e_operation.o_56,
				_s_operation._e_operation.o_57,
				_s_operation._e_operation.o_58,
				_s_operation._e_operation.o_59,
				_s_operation._e_operation.o_60,
				_s_operation._e_operation.o_61,
				_s_operation._e_operation.o_62,
				_s_operation._e_operation.o_63,
				_s_operation._e_operation.o_64,
				_s_operation._e_operation.o_65,
				_s_operation._e_operation.o_66,
				_s_operation._e_operation.o_67,
				_s_operation._e_operation.o_68,
				_s_operation._e_operation.o_69,
				_s_operation._e_operation.o_70,
				_s_operation._e_operation.o_71,
				_s_operation._e_operation.o_72,
				_s_operation._e_operation.o_73,
				_s_operation._e_operation.o_74,
				_s_operation._e_operation.o_75,
				_s_operation._e_operation.o_76,
				_s_operation._e_operation.o_77,
				_s_operation._e_operation.o_78,
				_s_operation._e_operation.o_79
			});
			comboBox_Type2.SelectedIndex = 0;
		}
		else if (comboBox_Type1.SelectedIndex == 2)
		{
			comboBox_Type2.Items.AddRange(new object[19]
			{
				_s_target._e_target.t_hate_first,
				_s_target._e_target.t_hate_second,
				_s_target._e_target.t_hate_others,
				_s_target._e_target.t_most_hp,
				_s_target._e_target.t_most_mp,
				_s_target._e_target.t_least_hp,
				_s_target._e_target.t_occupation_list,
				_s_target._e_target.t_self,
				_s_target._e_target.t_monster_killer,
				_s_target._e_target.t_monster_birthplace_faction,
				_s_target._e_target.t_hate_random_one,
				_s_target._e_target.t_hate_nearest,
				_s_target._e_target.t_hate_farthest,
				_s_target._e_target.t_hate_first_redirected,
				_s_target._e_target.t_14,
				_s_target._e_target.t_15,
				_s_target._e_target.t_16,
				_s_target._e_target.t_17,
				_s_target._e_target.t_18
			});
			comboBox_Type2.SelectedIndex = 0;
		}
	}

	private void button_Search_Click(object sender, EventArgs e)
	{
		results.Clear();
		results_indexes.Clear();
		listBox_Result.Items.Clear();
		string str = textBox_Value.Text;
		foreach (CPolicyData item in AIPolicy.listPolicy)
		{
			if (Check.CheckValue(item.uID, str))
			{
				results.Add(new int[1] { item.uID });
				results_indexes.Add(new int[1] { AIPolicy.listPolicy.IndexOf(item) });
			}
			foreach (CTriggerData item2 in item.listTriggerPtr)
			{
				if (Check.CheckValue(item2.uID, str) || Check.CheckValue(item2.szName, str) || _s_tree_item.Search(item2.rootConditon, str))
				{
					results.Add(new int[2] { item.uID, item2.uID });
					results_indexes.Add(new int[2]
					{
						AIPolicy.listPolicy.IndexOf(item),
						item.listTriggerPtr.IndexOf(item2)
					});
				}
				foreach (_s_operation item3 in item2.listOperation)
				{
					if (item3.Search(str, item2.dwVersion))
					{
						results.Add(new int[3]
						{
							item.uID,
							item2.uID,
							item2.listOperation.IndexOf(item3)
						});
						results_indexes.Add(new int[3]
						{
							AIPolicy.listPolicy.IndexOf(item),
							item.listTriggerPtr.IndexOf(item2),
							item2.listOperation.IndexOf(item3)
						});
					}
				}
			}
		}
		foreach (int[] result in results)
		{
			switch (result.Length)
			{
			case 1:
				listBox_Result.Items.Add($"Policy {result[0]}");
				break;
			case 2:
				listBox_Result.Items.Add($"Policy {result[0]}, Trigger {result[1]}");
				break;
			case 3:
				listBox_Result.Items.Add($"Policy {result[0]}, Trigger {result[1]}, Operation {result[2] + 1}");
				break;
			}
		}
	}

	private void button_SearchByType_Click(object sender, EventArgs e)
	{
		results.Clear();
		results_indexes.Clear();
		listBox_Result.Items.Clear();
		if (comboBox_Type1.SelectedIndex == 0)
		{
			foreach (CPolicyData item in AIPolicy.listPolicy)
			{
				foreach (CTriggerData item2 in item.listTriggerPtr)
				{
					if (_s_tree_item.Search(item2.rootConditon, (_s_condition._e_condition)comboBox_Type2.SelectedIndex))
					{
						results.Add(new int[2] { item.uID, item2.uID });
						results_indexes.Add(new int[2]
						{
							AIPolicy.listPolicy.IndexOf(item),
							item.listTriggerPtr.IndexOf(item2)
						});
					}
				}
			}
		}
		else if (comboBox_Type1.SelectedIndex == 1)
		{
			foreach (CPolicyData item3 in AIPolicy.listPolicy)
			{
				foreach (CTriggerData item4 in item3.listTriggerPtr)
				{
					foreach (_s_operation item5 in item4.listOperation)
					{
						if (item5.iType == (_s_operation._e_operation)comboBox_Type2.SelectedIndex)
						{
							results.Add(new int[3]
							{
								item3.uID,
								item4.uID,
								item4.listOperation.IndexOf(item5)
							});
							results_indexes.Add(new int[3]
							{
								AIPolicy.listPolicy.IndexOf(item3),
								item3.listTriggerPtr.IndexOf(item4),
								item4.listOperation.IndexOf(item5)
							});
						}
					}
				}
			}
		}
		else if (comboBox_Type1.SelectedIndex == 2)
		{
			foreach (CPolicyData item6 in AIPolicy.listPolicy)
			{
				foreach (CTriggerData item7 in item6.listTriggerPtr)
				{
					foreach (_s_operation item8 in item7.listOperation)
					{
						if (item8.mTarget.iType == (_s_target._e_target)comboBox_Type2.SelectedIndex)
						{
							results.Add(new int[3]
							{
								item6.uID,
								item7.uID,
								item7.listOperation.IndexOf(item8)
							});
							results_indexes.Add(new int[3]
							{
								AIPolicy.listPolicy.IndexOf(item6),
								item6.listTriggerPtr.IndexOf(item7),
								item7.listOperation.IndexOf(item8)
							});
						}
					}
				}
			}
		}
		foreach (int[] result in results)
		{
			switch (result.Length)
			{
			case 1:
				listBox_Result.Items.Add($"Policy {result[0]}");
				break;
			case 2:
				listBox_Result.Items.Add($"Policy {result[0]}, Trigger {result[1]}");
				break;
			case 3:
				listBox_Result.Items.Add($"Policy {result[0]}, Trigger {result[1]}, Operation {result[2]}");
				break;
			}
		}
	}

	private void listBox_Result_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (listBox_Result.SelectedIndex > -1)
		{
			if (results[listBox_Result.SelectedIndex].Length != 0)
			{
				MW.listBox_listPolicy.SelectedItems.Clear();
				MW.listBox_listPolicy.SelectedIndex = results_indexes[listBox_Result.SelectedIndex][0];
			}
			if (results[listBox_Result.SelectedIndex].Length > 1)
			{
				MW.listBox_listTriggerPtr.SelectedItems.Clear();
				MW.listBox_listTriggerPtr.SelectedIndex = results_indexes[listBox_Result.SelectedIndex][1];
			}
			if (results[listBox_Result.SelectedIndex].Length > 2)
			{
				MW.listBox_listOperation.SelectedItems.Clear();
				MW.listBox_listOperation.SelectedIndex = results_indexes[listBox_Result.SelectedIndex][2];
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIPolicyEditor.SearchWindow));
		this.listBox_Result = new System.Windows.Forms.ListBox();
		this.textBox_Value = new System.Windows.Forms.TextBox();
		this.button_Search = new System.Windows.Forms.Button();
		this.comboBox_Type1 = new System.Windows.Forms.ComboBox();
		this.comboBox_Type2 = new System.Windows.Forms.ComboBox();
		this.button_SearchByType = new System.Windows.Forms.Button();
		base.SuspendLayout();
		resources.ApplyResources(this.listBox_Result, "listBox_Result");
		this.listBox_Result.FormattingEnabled = true;
		this.listBox_Result.Name = "listBox_Result";
		this.listBox_Result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(listBox_Result_MouseDoubleClick);
		resources.ApplyResources(this.textBox_Value, "textBox_Value");
		this.textBox_Value.Name = "textBox_Value";
		resources.ApplyResources(this.button_Search, "button_Search");
		this.button_Search.Name = "button_Search";
		this.button_Search.UseVisualStyleBackColor = true;
		this.button_Search.Click += new System.EventHandler(button_Search_Click);
		resources.ApplyResources(this.comboBox_Type1, "comboBox_Type1");
		this.comboBox_Type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox_Type1.FormattingEnabled = true;
		this.comboBox_Type1.Items.AddRange(new object[3]
		{
			resources.GetString("comboBox_Type1.Items"),
			resources.GetString("comboBox_Type1.Items1"),
			resources.GetString("comboBox_Type1.Items2")
		});
		this.comboBox_Type1.Name = "comboBox_Type1";
		this.comboBox_Type1.SelectedIndexChanged += new System.EventHandler(comboBox_Type1_SelectedIndexChanged);
		resources.ApplyResources(this.comboBox_Type2, "comboBox_Type2");
		this.comboBox_Type2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.comboBox_Type2.FormattingEnabled = true;
		this.comboBox_Type2.Name = "comboBox_Type2";
		resources.ApplyResources(this.button_SearchByType, "button_SearchByType");
		this.button_SearchByType.Name = "button_SearchByType";
		this.button_SearchByType.UseVisualStyleBackColor = true;
		this.button_SearchByType.Click += new System.EventHandler(button_SearchByType_Click);
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.button_SearchByType);
		base.Controls.Add(this.comboBox_Type2);
		base.Controls.Add(this.comboBox_Type1);
		base.Controls.Add(this.button_Search);
		base.Controls.Add(this.textBox_Value);
		base.Controls.Add(this.listBox_Result);
		base.Name = "SearchWindow";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
