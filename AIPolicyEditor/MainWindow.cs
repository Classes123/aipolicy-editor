using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using AIPolicyEditor.aipolicy.data;
using AIPolicyEditor.aipolicy.data.Conditions;
using AIPolicyEditor.aipolicy.data.Operations;

namespace AIPolicyEditor;

public class MainWindow : Form
{
	public CPolicyDataManager AIPolicy;

	private string Path;

	public static bool LockTarget = true;

	public static bool LockCondition = true;

	private IContainer components;

	private MenuStrip menuStrip_Main;

	private ToolStripMenuItem toolStripMenuItem_Load;

	private PropertyGrid propertyGrid_rootConditon;

	private CheckBox checkBox_Active;

	private CheckBox checkBox_Run;

	private CheckBox checkBox_AttackValid;

	private Label label_Name;

	private TextBox textBox_Name;

	public PropertyGrid propertyGrid_Operation;

	private ContextMenuStrip contextMenuStrip_Operation;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd;

	private ToolStripMenuItem toolStripMenuItem_OperationRemove;

	private ContextMenuStrip contextMenuStrip_Policy;

	private ToolStripMenuItem toolStripMenuItem_PolicyAdd;

	private ToolStripMenuItem toolStripMenuItem_PolicyRemove;

	private ContextMenuStrip contextMenuStrip_Trigger;

	private ToolStripMenuItem toolStripMenuItem_TriggerAdd;

	private ToolStripMenuItem toolStripMenuItem_TriggerRemove;

	private ContextMenuStrip contextMenuStrip_rootConditon;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd;

	private ToolStripMenuItem toolStripMenuItem_ConditonRemove;

	private ToolStripMenuItem toolStripMenuItem_Save;

	private ToolStripMenuItem toolStripMenuItem_PolicyCopy;

	private ToolStripMenuItem toolStripMenuItem_TriggerCopy;

	private ToolStripMenuItem toolStripMenuItem_OperationCopy;

	private ToolStripMenuItem toolStripMenuItem_Search;

	public ListBox listBox_listPolicy;

	public ListBox listBox_listTriggerPtr;

	public ListBox listBox_listOperation;

	private TextBox textBox_Condition;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_attact;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_use_skill;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_talk;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_reset_hate_list;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_run_trigger;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_stop_trigger;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_active_trigger;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_create_timer;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_kill_timer;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_flee;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_set_hate_to_first;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_set_hate_to_last;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_skip_operation;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_active_controller;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_set_global;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_revise_global;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_summon_monster;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_walk_along;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_play_action;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_revise_history;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_set_history;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_calc_var;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_summon_monster_2;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_walk_along_2;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_use_skill_2;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_active_controller_2;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_deliver_task;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_summon_mine;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_summon_npc;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_36;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_37;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_38;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_39;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_40;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_41;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_42;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_43;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_44;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_45;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_46;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_47;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_48;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_49;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_50;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_51;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_52;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_53;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_54;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_55;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_56;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_57;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_58;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_59;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_60;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_61;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_62;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_63;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_64;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_65;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_66;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_67;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_68;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_69;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_70;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_71;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_72;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_73;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_74;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_75;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_76;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_77;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_78;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_79;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_80;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_81;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_82;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_83;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_84;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_85;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_86;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_87;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_88;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_89;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_90;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_91;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_92;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_93;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_94;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_95;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_96;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_97;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_98;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_99;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_100;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_101;

	private ToolStripMenuItem toolStripMenuItem_OperationAdd_o_102;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_time_come;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_hp_less;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_start_attack;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_random;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_kill_player;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_not;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_or;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_and;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_died;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_plus;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_minus;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_multiply;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_divide;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_great;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_less;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_equ;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_var;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_constant;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_be_hurt;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_reach_end;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_at_history_stage;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_history_value;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_stop_fight;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_local_var;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_reach_end_2;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_has_filter;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_room_index;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_player_count_in_radius;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_player_count_in_region;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_29;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_30;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_31;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_32;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_33;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_34;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_35;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_36;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_37;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_38;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_39;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_40;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_41;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_42;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_43;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_44;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_45;

	private ToolStripMenuItem toolStripMenuItem_ConditionAdd_c_46;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void toolStripMenuItem_Load_Click(object sender, EventArgs e)
	{
		AIPolicy = new CPolicyDataManager();
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "Aipolicy.data(*.data)|*.data|Все файлы(*.*)|*.*"
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			listBox_listPolicy.Items.Clear();
			AIPolicy.Read(openFileDialog.FileName);
			Path = openFileDialog.FileName;
			Text = "AipolicyEditor  " + Path;
			for (int i = 0; i < AIPolicy.listPolicy.Count; i++)
			{
				listBox_listPolicy.Items.Add("[" + (i + 1) + "] " + AIPolicy.listPolicy[i].uID);
			}
			if (AIPolicy.listPolicy.Count > 0)
			{
				listBox_listPolicy.SelectedIndex = 0;
			}
		}
	}

	private void toolStripMenuItem_Save_Click(object sender, EventArgs e)
	{
		if (Path != null)
		{
			if (File.Exists(Path))
			{
				File.Copy(Path, Path + ".bak", overwrite: true);
			}
			AIPolicy.Write(Path);
			MessageBox.Show("Успешно сохранено!");
		}
	}

	private void listBox_listPolicy_SelectedIndexChanged(object sender, EventArgs e)
	{
		listBox_listTriggerPtr.Items.Clear();
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		if (selectedIndex > -1)
		{
			for (int i = 0; i < AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Count; i++)
			{
				listBox_listTriggerPtr.Items.Add("[" + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[i].uID + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[i].szName);
			}
			if (listBox_listTriggerPtr.Items.Count > 0)
			{
				listBox_listTriggerPtr.SelectedIndex = 0;
				return;
			}
			listBox_listTriggerPtr.SelectedIndex = -1;
			checkBox_Active.Checked = false;
			checkBox_Run.Checked = false;
			checkBox_AttackValid.Checked = false;
			textBox_Name.Text = "";
			propertyGrid_rootConditon.SelectedObject = null;
			textBox_Condition.Text = "";
			listBox_listOperation.Items.Clear();
			propertyGrid_Operation.SelectedObject = null;
			listBox_listOperation.SelectedIndex = -1;
		}
	}

	private void listBox_listTriggerPtr_SelectedIndexChanged(object sender, EventArgs e)
	{
		listBox_listOperation.Items.Clear();
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 > -1)
		{
			LockCondition = true;
			checkBox_Active.Checked = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bActive;
			checkBox_Run.Checked = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bRun;
			checkBox_AttackValid.Checked = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bAttackValid;
			textBox_Name.Text = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].szName;
			propertyGrid_rootConditon.SelectedObject = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon;
			textBox_Condition.Text = ConditionToString(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon);
			for (int i = 0; i < AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Count; i++)
			{
				listBox_listOperation.Items.Add("[" + (i + 1) + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[i].iType);
			}
			if (listBox_listOperation.Items.Count > 0)
			{
				listBox_listOperation.SelectedIndex = 0;
			}
			else
			{
				listBox_listOperation.SelectedIndex = -1;
			}
			LockCondition = false;
		}
	}

	private void listBox_listOperation_SelectedIndexChanged(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		int selectedIndex3 = listBox_listOperation.SelectedIndex;
		if (listBox_listOperation.Items.Count > 0 && selectedIndex2 > -1 && selectedIndex3 > -1)
		{
			LockTarget = true;
			propertyGrid_Operation.SelectedObject = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[selectedIndex3];
			propertyGrid_Operation.ExpandAllGridItems();
			LockTarget = false;
		}
	}

	private void propertyGrid_rootConditon_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
	{
		if (e.ChangedItem.Label == "iType")
		{
			propertyGrid_rootConditon.Refresh();
		}
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		textBox_Condition.Text = ConditionToString(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon);
	}

	private void propertyGrid_Operation_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
	{
		if (e.ChangedItem.Label == "iType")
		{
			propertyGrid_Operation.Refresh();
		}
	}

	private void checkBox_Active_CheckedChanged(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 > -1)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bActive = checkBox_Active.Checked;
		}
	}

	private void checkBox_Run_CheckedChanged(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 > -1)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bRun = checkBox_Run.Checked;
		}
	}

	private void checkBox_AttackValid_CheckedChanged(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 > -1)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].bAttackValid = checkBox_AttackValid.Checked;
		}
	}

	private void textBox_Name_Leave(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 > -1)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].szName = textBox_Name.Text;
			listBox_listTriggerPtr.Items[selectedIndex2] = "[" + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].uID + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].szName;
		}
	}

	private void toolStripMenuItem_PolicyAdd_Click(object sender, EventArgs e)
	{
		if (listBox_listPolicy.SelectedIndex > -1)
		{
			CPolicyData cPolicyData = new CPolicyData();
			cPolicyData.uID = GetPolicyMaxID(AIPolicy.listPolicy) + 1;
			int count = AIPolicy.listPolicy.Count;
			AIPolicy.listPolicy.Add(cPolicyData);
			listBox_listPolicy.Items.Add(AIPolicy.listPolicy[count].uID);
			listBox_listPolicy.SelectedItems.Clear();
			listBox_listPolicy.SelectedIndex = count;
		}
	}

	private void toolStripMenuItem_PolicyCopy_Click(object sender, EventArgs e)
	{
		ListBox.SelectedIndexCollection selectedIndices = listBox_listPolicy.SelectedIndices;
		if (selectedIndices.Count > 0)
		{
			int num = GetPolicyMaxID(AIPolicy.listPolicy);
			for (int i = 0; i < selectedIndices.Count; i++)
			{
				CPolicyData cPolicyData = new CPolicyData();
				cPolicyData = AIPolicy.listPolicy[selectedIndices[i]].Copy() as CPolicyData;
				num = (cPolicyData.uID = num + 1);
				AIPolicy.listPolicy.Add(cPolicyData);
				listBox_listPolicy.Items.Add(AIPolicy.listPolicy[AIPolicy.listPolicy.Count - 1].uID);
			}
			listBox_listPolicy.SelectedItems.Clear();
			listBox_listPolicy.SelectedIndex = AIPolicy.listPolicy.Count - 1;
		}
	}

	private void toolStripMenuItem_PolicyRemove_Click(object sender, EventArgs e)
	{
		ListBox.SelectedIndexCollection selectedIndices = listBox_listPolicy.SelectedIndices;
		if (selectedIndices.Count <= 0)
		{
			return;
		}
		int num = selectedIndices[0];
		for (int num2 = selectedIndices.Count - 1; num2 > -1; num2--)
		{
			AIPolicy.listPolicy.RemoveAt(selectedIndices[num2]);
			listBox_listPolicy.Items.RemoveAt(selectedIndices[num2]);
		}
		if (listBox_listPolicy.Items.Count > 0)
		{
			if (num != 0)
			{
				listBox_listPolicy.SelectedIndex = num - 1;
			}
			else
			{
				listBox_listPolicy.SelectedIndex = 0;
			}
		}
		else
		{
			listBox_listPolicy.SelectedIndex = -1;
		}
	}

	private void toolStripMenuItem_TriggerAdd_Click(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		if (selectedIndex > -1)
		{
			CTriggerData cTriggerData = new CTriggerData();
			cTriggerData.dwVersion = AIPolicy.listPolicy[0].listTriggerPtr[0].dwVersion;
			cTriggerData.uID = GetTriggerMaxID(AIPolicy.listPolicy[selectedIndex].listTriggerPtr) + 1;
			cTriggerData.rootConditon.mConditon.pParam = new C_TIME_COME();
			int count = AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Count;
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Add(cTriggerData);
			listBox_listTriggerPtr.Items.Add("[" + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[count].uID + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[count].szName);
			listBox_listTriggerPtr.SelectedItems.Clear();
			listBox_listTriggerPtr.SelectedIndex = count;
		}
	}

	private void toolStripMenuItem_TriggerCopy_Click(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		ListBox.SelectedIndexCollection selectedIndices = listBox_listTriggerPtr.SelectedIndices;
		if (selectedIndices.Count > 0)
		{
			int num = GetTriggerMaxID(AIPolicy.listPolicy[selectedIndex].listTriggerPtr);
			for (int i = 0; i < selectedIndices.Count; i++)
			{
				CTriggerData cTriggerData = new CTriggerData();
				cTriggerData = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndices[i]].Copy() as CTriggerData;
				num = (cTriggerData.uID = num + 1);
				int count = AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Count;
				AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Add(cTriggerData);
				listBox_listTriggerPtr.Items.Add("[" + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[count].uID + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[count].szName);
			}
			listBox_listTriggerPtr.SelectedItems.Clear();
			listBox_listTriggerPtr.SelectedIndex = AIPolicy.listPolicy[selectedIndex].listTriggerPtr.Count - 1;
		}
	}

	private void toolStripMenuItem_TriggerRemove_Click(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		ListBox.SelectedIndexCollection selectedIndices = listBox_listTriggerPtr.SelectedIndices;
		if (selectedIndices.Count <= -1)
		{
			return;
		}
		int num = selectedIndices[0];
		for (int num2 = selectedIndices.Count - 1; num2 > -1; num2--)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr.RemoveAt(selectedIndices[num2]);
			listBox_listTriggerPtr.Items.RemoveAt(selectedIndices[num2]);
		}
		if (listBox_listTriggerPtr.Items.Count > 0)
		{
			if (num != 0)
			{
				listBox_listTriggerPtr.SelectedIndex = num - 1;
			}
			else
			{
				listBox_listTriggerPtr.SelectedIndex = 0;
			}
		}
		else
		{
			listBox_listTriggerPtr.SelectedIndex = -1;
		}
	}

	private void ConditonAdd(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if ((!(propertyGrid_rootConditon.SelectedGridItem.Label == "Начало") && !(propertyGrid_rootConditon.SelectedGridItem.Label == "Конец")) || propertyGrid_rootConditon.SelectedGridItem.GridItems.Count != 0)
		{
			return;
		}
		GridItem selectedGridItem = propertyGrid_rootConditon.SelectedGridItem;
		int num = -1;
		List<int> list = new List<int>();
		while (true)
		{
			if (selectedGridItem.Label == "Начало")
			{
				list.Add(0);
			}
			else if (selectedGridItem.Label == "Конец")
			{
				list.Add(1);
			}
			if (selectedGridItem.Parent == null)
			{
				break;
			}
			selectedGridItem = selectedGridItem.Parent;
			num++;
		}
		AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon = AddTreeItem(sender, AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon, list, num);
		propertyGrid_rootConditon.Refresh();
		textBox_Condition.Text = ConditionToString(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon);
	}

	private _s_tree_item AddTreeItem(object sender, _s_tree_item node, List<int> types, int depth)
	{
		if (depth == 0)
		{
			if (types[depth] == 0)
			{
				node.pLeft = new _s_tree_item();
				node.pLeft.mConditon.iType = (_s_condition._e_condition)System.Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
			}
			else
			{
				node.pRight = new _s_tree_item();
				node.pRight.mConditon.iType = (_s_condition._e_condition)System.Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
			}
			return node;
		}
		if (types[depth] == 0)
		{
			node.pLeft = AddTreeItem(sender, node.pLeft, types, depth - 1);
		}
		else
		{
			node.pRight = AddTreeItem(sender, node.pRight, types, depth - 1);
		}
		return node;
	}

	private void toolStripMenuItem_ConditonRemove_Click(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (!(propertyGrid_rootConditon.SelectedGridItem.Label == "Начало") && !(propertyGrid_rootConditon.SelectedGridItem.Label == "Конец"))
		{
			return;
		}
		GridItem selectedGridItem = propertyGrid_rootConditon.SelectedGridItem;
		int num = -1;
		List<int> list = new List<int>();
		while (true)
		{
			if (selectedGridItem.Label == "Начало")
			{
				list.Add(0);
			}
			else if (selectedGridItem.Label == "Конец")
			{
				list.Add(1);
			}
			if (selectedGridItem.Parent == null)
			{
				break;
			}
			selectedGridItem = selectedGridItem.Parent;
			num++;
		}
		AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon = RemoveTreeItem(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon, list, num);
		propertyGrid_rootConditon.Refresh();
		textBox_Condition.Text = ConditionToString(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].rootConditon);
	}

	private _s_tree_item RemoveTreeItem(_s_tree_item node, List<int> types, int depth)
	{
		if (depth == 0)
		{
			if (types[depth] == 0)
			{
				node.pLeft = null;
			}
			else
			{
				node.pRight = null;
			}
			return node;
		}
		if (types[depth] == 0)
		{
			node.pLeft = RemoveTreeItem(node.pLeft, types, depth - 1);
		}
		else
		{
			node.pRight = RemoveTreeItem(node.pRight, types, depth - 1);
		}
		return node;
	}

	private void OperationAdd(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		if (selectedIndex2 <= -1)
		{
			return;
		}
		_s_operation s_operation = new _s_operation();
		if (sender == toolStripMenuItem_OperationAdd_o_attact)
		{
			s_operation.iType = _s_operation._e_operation.o_attact;
			s_operation.pParam = new O_ATTACK_TYPE();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_use_skill)
		{
			s_operation.iType = _s_operation._e_operation.o_use_skill;
			s_operation.pParam = new O_USE_SKILL();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_talk)
		{
			s_operation.iType = _s_operation._e_operation.o_talk;
			s_operation.pParam = new O_TALK_TEXT();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_reset_hate_list)
		{
			s_operation.iType = _s_operation._e_operation.o_reset_hate_list;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_run_trigger)
		{
			s_operation.iType = _s_operation._e_operation.o_run_trigger;
			s_operation.pParam = new O_RUN_TRIGGER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_stop_trigger)
		{
			s_operation.iType = _s_operation._e_operation.o_stop_trigger;
			s_operation.pParam = new O_STOP_TRIGGER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_active_trigger)
		{
			s_operation.iType = _s_operation._e_operation.o_active_trigger;
			s_operation.pParam = new O_ACTIVE_TRIGGER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_create_timer)
		{
			s_operation.iType = _s_operation._e_operation.o_create_timer;
			s_operation.pParam = new O_CREATE_TIMER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_kill_timer)
		{
			s_operation.iType = _s_operation._e_operation.o_kill_timer;
			s_operation.pParam = new O_KILL_TIMER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_flee)
		{
			s_operation.iType = _s_operation._e_operation.o_flee;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_set_hate_to_first)
		{
			s_operation.iType = _s_operation._e_operation.o_set_hate_to_first;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_set_hate_to_last)
		{
			s_operation.iType = _s_operation._e_operation.o_set_hate_to_last;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent)
		{
			s_operation.iType = _s_operation._e_operation.o_set_hate_fifty_percent;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_skip_operation)
		{
			s_operation.iType = _s_operation._e_operation.o_skip_operation;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_active_controller)
		{
			s_operation.iType = _s_operation._e_operation.o_active_controller;
			s_operation.pParam = new O_ACTIVE_CONTROLLER();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_set_global)
		{
			s_operation.iType = _s_operation._e_operation.o_set_global;
			if (AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].dwVersion >= 4)
			{
				s_operation.pParam = new O_SET_GLOBAL();
			}
			else
			{
				s_operation.pParam = new O_SET_GLOBAL_VERSION3();
			}
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_revise_global)
		{
			s_operation.iType = _s_operation._e_operation.o_revise_global;
			s_operation.pParam = new O_REVISE_GLOBAL();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_summon_monster)
		{
			s_operation.iType = _s_operation._e_operation.o_summon_monster;
			if (AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].dwVersion >= 7)
			{
				s_operation.pParam = new O_SUMMON_MONSTER();
			}
			else
			{
				s_operation.pParam = new O_SUMMON_MONSTER_VERSION6();
			}
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_walk_along)
		{
			s_operation.iType = _s_operation._e_operation.o_walk_along;
			s_operation.pParam = new O_WALK_ALONG();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_play_action)
		{
			s_operation.iType = _s_operation._e_operation.o_play_action;
			if (AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].dwVersion >= 9)
			{
				s_operation.pParam = new O_PLAY_ACTION();
			}
			else
			{
				s_operation.pParam = new O_PLAY_ACTION_VERSION8();
			}
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_revise_history)
		{
			s_operation.iType = _s_operation._e_operation.o_revise_history;
			s_operation.pParam = new O_REVISE_HISTORY();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_set_history)
		{
			s_operation.iType = _s_operation._e_operation.o_set_history;
			s_operation.pParam = new O_SET_HISTORY();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points)
		{
			s_operation.iType = _s_operation._e_operation.o_deliver_faction_pvp_points;
			s_operation.pParam = new O_DELIVER_FACTION_PVP_POINTS();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_calc_var)
		{
			s_operation.iType = _s_operation._e_operation.o_calc_var;
			s_operation.pParam = new O_CALC_VAR();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_summon_monster_2)
		{
			s_operation.iType = _s_operation._e_operation.o_summon_monster_2;
			s_operation.pParam = new O_SUMMON_MONSTER_2();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_walk_along_2)
		{
			s_operation.iType = _s_operation._e_operation.o_walk_along_2;
			s_operation.pParam = new O_WALK_ALONG_2();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_use_skill_2)
		{
			s_operation.iType = _s_operation._e_operation.o_use_skill_2;
			s_operation.pParam = new O_USE_SKILL_2();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_active_controller_2)
		{
			s_operation.iType = _s_operation._e_operation.o_active_controller_2;
			s_operation.pParam = new O_ACTIVE_CONTROLLER_2();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_deliver_task)
		{
			s_operation.iType = _s_operation._e_operation.o_deliver_task;
			s_operation.pParam = new O_DELIVER_TASK();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_summon_mine)
		{
			s_operation.iType = _s_operation._e_operation.o_summon_mine;
			s_operation.pParam = new O_SUMMON_MINE();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_summon_npc)
		{
			s_operation.iType = _s_operation._e_operation.o_summon_npc;
			s_operation.pParam = new O_SUMMON_NPC();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region)
		{
			s_operation.iType = _s_operation._e_operation.o_deliver_random_task_in_region;
			s_operation.pParam = new O_DELIVER_RANDOM_TASK_IN_REGION();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list)
		{
			s_operation.iType = _s_operation._e_operation.o_deliver_task_in_hate_list;
			s_operation.pParam = new O_DELIVER_TASK_IN_HATE_LIST();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region)
		{
			s_operation.iType = _s_operation._e_operation.o_clear_tower_task_in_region;
			s_operation.pParam = new O_CLEAR_TOWER_TASK_IN_REGION();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param)
		{
			s_operation.iType = _s_operation._e_operation.o_save_player_count_in_radius_to_param;
			s_operation.pParam = new O_SAVE_PLAYER_COUNT_IN_RADIUS_TO_PARAM();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param)
		{
			s_operation.iType = _s_operation._e_operation.o_save_player_count_in_region_to_param;
			s_operation.pParam = new O_SAVE_PLAYER_COUNT_IN_REGION_TO_PARAM();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_36)
		{
			s_operation.iType = _s_operation._e_operation.o_36;
			s_operation.pParam = new O_36();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_37)
		{
			s_operation.iType = _s_operation._e_operation.o_37;
			s_operation.pParam = new O_37();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_38)
		{
			s_operation.iType = _s_operation._e_operation.o_38;
			s_operation.pParam = new O_38();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_39)
		{
			s_operation.iType = _s_operation._e_operation.o_39;
			s_operation.pParam = new O_39();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_40)
		{
			s_operation.iType = _s_operation._e_operation.o_40;
			s_operation.pParam = new O_40();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_41)
		{
			s_operation.iType = _s_operation._e_operation.o_41;
			s_operation.pParam = new O_41();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_42)
		{
			s_operation.iType = _s_operation._e_operation.o_42;
			s_operation.pParam = new O_42();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_43)
		{
			s_operation.iType = _s_operation._e_operation.o_43;
			s_operation.pParam = new O_43();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_44)
		{
			s_operation.iType = _s_operation._e_operation.o_44;
			s_operation.pParam = new O_44();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_45)
		{
			s_operation.iType = _s_operation._e_operation.o_45;
			s_operation.pParam = new O_45();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_46)
		{
			s_operation.iType = _s_operation._e_operation.o_46;
			s_operation.pParam = new O_46();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_47)
		{
			s_operation.iType = _s_operation._e_operation.o_47;
			s_operation.pParam = new O_47();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_48)
		{
			s_operation.iType = _s_operation._e_operation.o_48;
			s_operation.pParam = new O_48();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_49)
		{
			s_operation.iType = _s_operation._e_operation.o_49;
			s_operation.pParam = new O_49();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_50)
		{
			s_operation.iType = _s_operation._e_operation.o_50;
			s_operation.pParam = new O_50();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_51)
		{
			s_operation.iType = _s_operation._e_operation.o_51;
			s_operation.pParam = new O_51();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_52)
		{
			s_operation.iType = _s_operation._e_operation.o_52;
			s_operation.pParam = new O_52();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_53)
		{
			s_operation.iType = _s_operation._e_operation.o_53;
			s_operation.pParam = new O_53();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_54)
		{
			s_operation.iType = _s_operation._e_operation.o_54;
			s_operation.pParam = new O_54();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_55)
		{
			s_operation.iType = _s_operation._e_operation.o_55;
			s_operation.pParam = new O_55();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_56)
		{
			s_operation.iType = _s_operation._e_operation.o_56;
			s_operation.pParam = new O_56();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_57)
		{
			s_operation.iType = _s_operation._e_operation.o_57;
			s_operation.pParam = new O_57();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_58)
		{
			s_operation.iType = _s_operation._e_operation.o_58;
			s_operation.pParam = new O_58();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_59)
		{
			s_operation.iType = _s_operation._e_operation.o_59;
			s_operation.pParam = new O_59();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_60)
		{
			s_operation.iType = _s_operation._e_operation.o_60;
			s_operation.pParam = new O_60();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_61)
		{
			s_operation.iType = _s_operation._e_operation.o_61;
			s_operation.pParam = new O_61();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_62)
		{
			s_operation.iType = _s_operation._e_operation.o_62;
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_63)
		{
			s_operation.iType = _s_operation._e_operation.o_63;
			s_operation.pParam = new O_63();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_64)
		{
			s_operation.iType = _s_operation._e_operation.o_64;
			s_operation.pParam = new O_64();
			for (int i = 0; i < 10; i++)
			{
				((O_64)s_operation.pParam).clControllers[i] = new POLICY_CONTROLLER_LIST();
			}
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_65)
		{
			s_operation.iType = _s_operation._e_operation.o_65;
			s_operation.pParam = new O_65();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_66)
		{
			s_operation.iType = _s_operation._e_operation.o_66;
			s_operation.pParam = new O_66();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_67)
		{
			s_operation.iType = _s_operation._e_operation.o_67;
			s_operation.pParam = new O_67();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_68)
		{
			s_operation.iType = _s_operation._e_operation.o_68;
			s_operation.pParam = new O_68();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_69)
		{
			s_operation.iType = _s_operation._e_operation.o_69;
			s_operation.pParam = new O_69();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_70)
		{
			s_operation.iType = _s_operation._e_operation.o_70;
			s_operation.pParam = new O_70();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_71)
		{
			s_operation.iType = _s_operation._e_operation.o_71;
			s_operation.pParam = new O_71();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_72)
		{
			s_operation.iType = _s_operation._e_operation.o_72;
			s_operation.pParam = new O_72();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_73)
		{
			s_operation.iType = _s_operation._e_operation.o_73;
			s_operation.pParam = new O_73();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_74)
		{
			s_operation.iType = _s_operation._e_operation.o_74;
			s_operation.pParam = new O_74();
			for (int j = 0; j < 6; j++)
			{
				((O_74)s_operation.pParam).unk1[j] = new POLICY_CONTROLLER_LIST();
			}
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_75)
		{
			s_operation.iType = _s_operation._e_operation.o_75;
			s_operation.pParam = new O_75();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_76)
		{
			s_operation.iType = _s_operation._e_operation.o_76;
			s_operation.pParam = new O_76();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_77)
		{
			s_operation.iType = _s_operation._e_operation.o_77;
			s_operation.pParam = new O_77();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_78)
		{
			s_operation.iType = _s_operation._e_operation.o_78;
			s_operation.pParam = new O_78();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_79)
		{
			s_operation.iType = _s_operation._e_operation.o_79;
			s_operation.pParam = new O_79();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_80)
		{
			s_operation.iType = _s_operation._e_operation.o_80;
			s_operation.pParam = new O_80();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_81)
		{
			s_operation.iType = _s_operation._e_operation.o_81;
			s_operation.pParam = new O_81();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_82)
		{
			s_operation.iType = _s_operation._e_operation.o_82;
			s_operation.pParam = new O_82();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_83)
		{
			s_operation.iType = _s_operation._e_operation.o_83;
			s_operation.pParam = new O_83();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_84)
		{
			s_operation.iType = _s_operation._e_operation.o_84;
			s_operation.pParam = new O_84();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_85)
		{
			s_operation.iType = _s_operation._e_operation.o_85;
			s_operation.pParam = new O_85();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_86)
		{
			s_operation.iType = _s_operation._e_operation.o_86;
			s_operation.pParam = new O_86();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_87)
		{
			s_operation.iType = _s_operation._e_operation.o_87;
			s_operation.pParam = new O_87();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_88)
		{
			s_operation.iType = _s_operation._e_operation.o_88;
			s_operation.pParam = new O_88();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_89)
		{
			s_operation.iType = _s_operation._e_operation.o_89;
			s_operation.pParam = new O_89();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_90)
		{
			s_operation.iType = _s_operation._e_operation.o_90;
			s_operation.pParam = new O_90();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_91)
		{
			s_operation.iType = _s_operation._e_operation.o_91;
			s_operation.pParam = new O_91();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_92)
		{
			s_operation.iType = _s_operation._e_operation.o_92;
			s_operation.pParam = new O_92();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_93)
		{
			s_operation.iType = _s_operation._e_operation.o_93;
			s_operation.pParam = new O_93();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_94)
		{
			s_operation.iType = _s_operation._e_operation.o_94;
			s_operation.pParam = new O_94();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_95)
		{
			s_operation.iType = _s_operation._e_operation.o_95;
			s_operation.pParam = new O_95();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_96)
		{
			s_operation.iType = _s_operation._e_operation.o_96;
			s_operation.pParam = new O_96();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_97)
		{
			s_operation.iType = _s_operation._e_operation.o_97;
			s_operation.pParam = new O_97();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_98)
		{
			s_operation.iType = _s_operation._e_operation.o_98;
			s_operation.pParam = new O_98();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_99)
		{
			s_operation.iType = _s_operation._e_operation.o_99;
			s_operation.pParam = new O_99();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_100)
		{
			s_operation.iType = _s_operation._e_operation.o_100;
			s_operation.pParam = new O_100();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_101)
		{
			s_operation.iType = _s_operation._e_operation.o_101;
			s_operation.pParam = new O_101();
		}
		else if (sender == toolStripMenuItem_OperationAdd_o_102)
		{
			s_operation.iType = _s_operation._e_operation.o_102;
			s_operation.pParam = new O_102();
		}
		AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Add(s_operation);
		int count = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Count;
		listBox_listOperation.Items.Add("[" + count + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[count - 1].iType);
		listBox_listOperation.SelectedItems.Clear();
		listBox_listOperation.SelectedIndex = count - 1;
	}

	private void toolStripMenuItem_OperationCopy_Click(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		ListBox.SelectedIndexCollection selectedIndices = listBox_listOperation.SelectedIndices;
		if (selectedIndices.Count > 0)
		{
			for (int i = 0; i < selectedIndices.Count; i++)
			{
				_s_operation s_operation = new _s_operation();
				s_operation = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[selectedIndices[i]].Copy(AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].dwVersion) as _s_operation;
				AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Add(s_operation);
				int count = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Count;
				listBox_listOperation.Items.Add("[" + count + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[count - 1].iType);
			}
			listBox_listOperation.SelectedItems.Clear();
			listBox_listOperation.SelectedIndex = AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Count - 1;
		}
	}

	private void OperationRemove(object sender, EventArgs e)
	{
		int selectedIndex = listBox_listPolicy.SelectedIndex;
		int selectedIndex2 = listBox_listTriggerPtr.SelectedIndex;
		ListBox.SelectedIndexCollection selectedIndices = listBox_listOperation.SelectedIndices;
		if (selectedIndices.Count <= -1)
		{
			return;
		}
		int num = selectedIndices[0];
		for (int num2 = selectedIndices.Count - 1; num2 > -1; num2--)
		{
			AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.RemoveAt(selectedIndices[num2]);
		}
		listBox_listOperation.Items.Clear();
		for (int i = 0; i < AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation.Count; i++)
		{
			listBox_listOperation.Items.Add("[" + (i + 1) + "] " + AIPolicy.listPolicy[selectedIndex].listTriggerPtr[selectedIndex2].listOperation[i].iType);
		}
		if (listBox_listOperation.Items.Count > 0)
		{
			if (num != 0)
			{
				listBox_listOperation.SelectedIndex = num - 1;
			}
			else
			{
				listBox_listOperation.SelectedIndex = 0;
			}
		}
		else
		{
			listBox_listOperation.SelectedIndex = -1;
		}
	}

	private void toolStripMenuItem_Search_Click(object sender, EventArgs e)
	{
		SearchWindow searchWindow = new SearchWindow(this);
		searchWindow.AIPolicy = AIPolicy;
		searchWindow.Show();
	}

	private int GetPolicyMaxID(ObservableCollection<CPolicyData> listPolicy)
	{
		int num = -1;
		for (int i = 0; i < listPolicy.Count; i++)
		{
			if (num < listPolicy[i].uID)
			{
				num = listPolicy[i].uID;
			}
		}
		return num;
	}

	private int GetTriggerMaxID(ObservableCollection<CTriggerData> listTrigger)
	{
		int num = -1;
		for (int i = 0; i < listTrigger.Count; i++)
		{
			if (num < listTrigger[i].uID)
			{
				num = listTrigger[i].uID;
			}
		}
		return num;
	}

	private string ConditionToString(_s_tree_item node)
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		if (node.pLeft != null)
		{
			text2 = ConditionToString(node.pLeft);
			if (node.pLeft.pLeft != null && node.pLeft.pRight != null)
			{
				text2 = "(" + text2 + ")";
			}
			text2 += " ";
		}
		if (node.pRight != null)
		{
			text3 = ConditionToString(node.pRight);
			if (node.pRight.pLeft != null && node.pRight.pRight != null)
			{
				text3 = "(" + text3 + ")";
			}
			text3 = " " + text3;
		}
		switch (node.mConditon.iType)
		{
		case _s_condition._e_condition.c_time_come:
			text = $"таймер({((C_TIME_COME)node.mConditon.pParam).uID})";
			break;
		case _s_condition._e_condition.c_hp_less:
			text = $"хп меньше({((C_HP_LESS)node.mConditon.pParam).fPercent})";
			break;
		case _s_condition._e_condition.c_start_attack:
			text = "Начало боя";
			break;
		case _s_condition._e_condition.c_random:
			text = $"рандом({((C_RANDOM)node.mConditon.pParam).fProbability})";
			break;
		case _s_condition._e_condition.c_kill_player:
			text = "игрок убит";
			break;
		case _s_condition._e_condition.c_not:
			text = "!=";
			break;
		case _s_condition._e_condition.c_or:
			text = "||";
			break;
		case _s_condition._e_condition.c_and:
			text = "&&";
			break;
		case _s_condition._e_condition.c_died:
			text = "Смерть";
			break;
		case _s_condition._e_condition.c_plus:
			text = "+";
			break;
		case _s_condition._e_condition.c_minus:
			text = "-";
			break;
		case _s_condition._e_condition.c_multiply:
			text = "*";
			break;
		case _s_condition._e_condition.c_divide:
			text = "/";
			break;
		case _s_condition._e_condition.c_great:
			text = ">";
			break;
		case _s_condition._e_condition.c_less:
			text = "<";
			break;
		case _s_condition._e_condition.c_equ:
			text = "==";
			break;
		case _s_condition._e_condition.c_var:
			text = $"Переменная({((C_VAR)node.mConditon.pParam).iID})";
			break;
		case _s_condition._e_condition.c_constant:
			text = $"Константа({((C_CONSTANT)node.mConditon.pParam).iValue})";
			break;
		case _s_condition._e_condition.c_be_hurt:
			text = $"Урон({((C_BE_HURT)node.mConditon.pParam).iHurtLow} - {((C_BE_HURT)node.mConditon.pParam).iHurtHigh})";
			break;
		case _s_condition._e_condition.c_reach_end:
			text = $"Конец_пути({((C_REACH_END)node.mConditon.pParam).iPathID})";
			break;
		case _s_condition._e_condition.c_at_history_stage:
			text = $"Пройден_Ист_этап({((C_HISTORY_STAGE)node.mConditon.pParam).iID})";
			break;
		case _s_condition._e_condition.c_history_value:
			text = $"Ист_значение({((C_HISTORY_VALUE)node.mConditon.pParam).iValue})";
			break;
		case _s_condition._e_condition.c_stop_fight:
			text = "Конец_боя";
			break;
		case _s_condition._e_condition.c_local_var:
			text = $"Локальная переменная({((C_LOCAL_VAR)node.mConditon.pParam).iID})";
			break;
		case _s_condition._e_condition.c_reach_end_2:
			text = $"Конец_пути_2({((C_REACH_END_2)node.mConditon.pParam).iPathID}, {((C_REACH_END_2)node.mConditon.pParam).iPathIDType})";
			break;
		case _s_condition._e_condition.c_has_filter:
			text = $"Имеет_фильтр({((C_HAS_FILTER)node.mConditon.pParam).iID})";
			break;
		case _s_condition._e_condition.c_room_index:
			text = "Индекс_комнаты";
			break;
		case _s_condition._e_condition.c_player_count_in_radius:
			text = $"Кол-во_игроков_в_радиусе({((C_PLAYER_COUNT_IN_RADIUS)node.mConditon.pParam).fRadius})";
			break;
		case _s_condition._e_condition.c_player_count_in_region:
			text = $"Кол-во_игроков_в_регионе(Min({((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMin.v[0]}, {((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMin.v[1]}, {((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMin.v[2]}), Max({((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMax.v[0]}, {((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMax.v[1]}, {((C_PLAYER_COUNT_IN_REGION)node.mConditon.pParam).zvMax.v[2]}))";
			break;
		case _s_condition._e_condition.c_29:
			text = $"c_29({((C_29)node.mConditon.pParam).Year}-{((C_29)node.mConditon.pParam).Month}-{((C_29)node.mConditon.pParam).Day} {((C_29)node.mConditon.pParam).Hour}:{((C_29)node.mConditon.pParam).Minute})";
			break;
		case _s_condition._e_condition.c_30:
			text = $"c_30({((C_30)node.mConditon.pParam).WDay} {((C_30)node.mConditon.pParam).Hour}:{((C_30)node.mConditon.pParam).Minute})";
			break;
		case _s_condition._e_condition.c_31:
			text = "c_31";
			break;
		case _s_condition._e_condition.c_32:
			text = $"c_32({((C_32)node.mConditon.pParam).unk1}, {((C_32)node.mConditon.pParam).unk1Type})";
			break;
		case _s_condition._e_condition.c_33:
			text = "c_33";
			break;
		case _s_condition._e_condition.c_34:
			text = $"c_34({((C_34)node.mConditon.pParam).uID}, {((C_34)node.mConditon.pParam).uIDType})";
			break;
		case _s_condition._e_condition.c_35:
			text = $"c_35({((C_35)node.mConditon.pParam).fRadius})";
			break;
		case _s_condition._e_condition.c_36:
			text = $"c_36(Min({((C_36)node.mConditon.pParam).zvMin.v[0]}, {((C_36)node.mConditon.pParam).zvMin.v[1]}, {((C_36)node.mConditon.pParam).zvMin.v[2]}), Max({((C_36)node.mConditon.pParam).zvMax.v[0]}, {((C_36)node.mConditon.pParam).zvMax.v[1]}, {((C_36)node.mConditon.pParam).zvMax.v[2]}))";
			break;
		case _s_condition._e_condition.c_37:
			text = $"c_37({((C_37)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_38:
			text = $"c_38({((C_38)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_39:
			text = $"c_39({((C_39)node.mConditon.pParam).unk1}, {((C_39)node.mConditon.pParam).unk2}, {((C_39)node.mConditon.pParam).unk2})";
			break;
		case _s_condition._e_condition.c_40:
			text = "c_40";
			break;
		case _s_condition._e_condition.c_41:
			text = $"c_41({((C_41)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_42:
			text = $"c_42({((C_42)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_43:
			text = $"c_43({((C_43)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_44:
			text = $"c_44({((C_44)node.mConditon.pParam).unk1})";
			break;
		case _s_condition._e_condition.c_45:
			text = "c_45";
			break;
		case _s_condition._e_condition.c_46:
			text = "c_46";
			break;
		}
		return text2 + text + text3;
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIPolicyEditor.MainWindow));
		this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
		this.toolStripMenuItem_Load = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_Search = new System.Windows.Forms.ToolStripMenuItem();
		this.listBox_listPolicy = new System.Windows.Forms.ListBox();
		this.contextMenuStrip_Policy = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.toolStripMenuItem_PolicyAdd = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_PolicyCopy = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_PolicyRemove = new System.Windows.Forms.ToolStripMenuItem();
		this.listBox_listTriggerPtr = new System.Windows.Forms.ListBox();
		this.contextMenuStrip_Trigger = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.toolStripMenuItem_TriggerAdd = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_TriggerCopy = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_TriggerRemove = new System.Windows.Forms.ToolStripMenuItem();
		this.listBox_listOperation = new System.Windows.Forms.ListBox();
		this.contextMenuStrip_Operation = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.toolStripMenuItem_OperationAdd = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_attact = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_use_skill = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_talk = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_reset_hate_list = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_run_trigger = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_stop_trigger = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_active_trigger = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_create_timer = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_kill_timer = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_flee = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_first = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_last = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_skip_operation = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_active_controller = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_set_global = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_revise_global = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_summon_monster = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_walk_along = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_play_action = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_revise_history = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_set_history = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_calc_var = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_summon_monster_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_walk_along_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_use_skill_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_active_controller_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_deliver_task = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_summon_mine = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_summon_npc = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_36 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_37 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_38 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_39 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_40 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_41 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_42 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_43 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_44 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_45 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_46 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_47 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_48 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_49 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_50 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_51 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_52 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_53 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_54 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_55 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_56 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_57 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_58 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_59 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_60 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_61 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_62 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_63 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_64 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_65 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_66 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_67 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_68 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_69 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_70 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_71 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_72 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_73 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_74 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_75 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_76 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_77 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_78 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_79 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_80 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_81 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_82 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_83 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_84 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_85 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_86 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_87 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_88 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_89 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_90 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_91 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_92 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_93 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_94 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_95 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_96 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_97 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_98 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_99 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_100 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_101 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationAdd_o_102 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationCopy = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_OperationRemove = new System.Windows.Forms.ToolStripMenuItem();
		this.propertyGrid_Operation = new System.Windows.Forms.PropertyGrid();
		this.propertyGrid_rootConditon = new System.Windows.Forms.PropertyGrid();
		this.contextMenuStrip_rootConditon = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.toolStripMenuItem_ConditionAdd = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_time_come = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_hp_less = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_start_attack = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_random = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_kill_player = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_not = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_or = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_and = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_died = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_plus = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_minus = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_multiply = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_divide = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_great = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_less = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_equ = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_var = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_constant = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_be_hurt = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_reach_end = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_at_history_stage = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_history_value = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_stop_fight = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_local_var = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_reach_end_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_has_filter = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_room_index = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_region = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_29 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_30 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_31 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_32 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_33 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_34 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_35 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_36 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_37 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_38 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_39 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_40 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_41 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_42 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_43 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_44 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_45 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditionAdd_c_46 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_ConditonRemove = new System.Windows.Forms.ToolStripMenuItem();
		this.checkBox_Active = new System.Windows.Forms.CheckBox();
		this.checkBox_Run = new System.Windows.Forms.CheckBox();
		this.checkBox_AttackValid = new System.Windows.Forms.CheckBox();
		this.label_Name = new System.Windows.Forms.Label();
		this.textBox_Name = new System.Windows.Forms.TextBox();
		this.textBox_Condition = new System.Windows.Forms.TextBox();
		this.menuStrip_Main.SuspendLayout();
		this.contextMenuStrip_Policy.SuspendLayout();
		this.contextMenuStrip_Trigger.SuspendLayout();
		this.contextMenuStrip_Operation.SuspendLayout();
		this.contextMenuStrip_rootConditon.SuspendLayout();
		base.SuspendLayout();
		resources.ApplyResources(this.menuStrip_Main, "menuStrip_Main");
		this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_Load, this.toolStripMenuItem_Save, this.toolStripMenuItem_Search });
		this.menuStrip_Main.Name = "menuStrip_Main";
		resources.ApplyResources(this.toolStripMenuItem_Load, "toolStripMenuItem_Load");
		this.toolStripMenuItem_Load.Name = "toolStripMenuItem_Load";
		this.toolStripMenuItem_Load.Click += new System.EventHandler(toolStripMenuItem_Load_Click);
		resources.ApplyResources(this.toolStripMenuItem_Save, "toolStripMenuItem_Save");
		this.toolStripMenuItem_Save.Name = "toolStripMenuItem_Save";
		this.toolStripMenuItem_Save.Click += new System.EventHandler(toolStripMenuItem_Save_Click);
		resources.ApplyResources(this.toolStripMenuItem_Search, "toolStripMenuItem_Search");
		this.toolStripMenuItem_Search.Name = "toolStripMenuItem_Search";
		this.toolStripMenuItem_Search.Click += new System.EventHandler(toolStripMenuItem_Search_Click);
		resources.ApplyResources(this.listBox_listPolicy, "listBox_listPolicy");
		this.listBox_listPolicy.ContextMenuStrip = this.contextMenuStrip_Policy;
		this.listBox_listPolicy.FormattingEnabled = true;
		this.listBox_listPolicy.Name = "listBox_listPolicy";
		this.listBox_listPolicy.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.listBox_listPolicy.SelectedIndexChanged += new System.EventHandler(listBox_listPolicy_SelectedIndexChanged);
		resources.ApplyResources(this.contextMenuStrip_Policy, "contextMenuStrip_Policy");
		this.contextMenuStrip_Policy.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_PolicyAdd, this.toolStripMenuItem_PolicyCopy, this.toolStripMenuItem_PolicyRemove });
		this.contextMenuStrip_Policy.Name = "contextMenuStrip_Policy";
		resources.ApplyResources(this.toolStripMenuItem_PolicyAdd, "toolStripMenuItem_PolicyAdd");
		this.toolStripMenuItem_PolicyAdd.Name = "toolStripMenuItem_PolicyAdd";
		this.toolStripMenuItem_PolicyAdd.Click += new System.EventHandler(toolStripMenuItem_PolicyAdd_Click);
		resources.ApplyResources(this.toolStripMenuItem_PolicyCopy, "toolStripMenuItem_PolicyCopy");
		this.toolStripMenuItem_PolicyCopy.Name = "toolStripMenuItem_PolicyCopy";
		this.toolStripMenuItem_PolicyCopy.Click += new System.EventHandler(toolStripMenuItem_PolicyCopy_Click);
		resources.ApplyResources(this.toolStripMenuItem_PolicyRemove, "toolStripMenuItem_PolicyRemove");
		this.toolStripMenuItem_PolicyRemove.Name = "toolStripMenuItem_PolicyRemove";
		this.toolStripMenuItem_PolicyRemove.Click += new System.EventHandler(toolStripMenuItem_PolicyRemove_Click);
		resources.ApplyResources(this.listBox_listTriggerPtr, "listBox_listTriggerPtr");
		this.listBox_listTriggerPtr.ContextMenuStrip = this.contextMenuStrip_Trigger;
		this.listBox_listTriggerPtr.FormattingEnabled = true;
		this.listBox_listTriggerPtr.Name = "listBox_listTriggerPtr";
		this.listBox_listTriggerPtr.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.listBox_listTriggerPtr.SelectedIndexChanged += new System.EventHandler(listBox_listTriggerPtr_SelectedIndexChanged);
		resources.ApplyResources(this.contextMenuStrip_Trigger, "contextMenuStrip_Trigger");
		this.contextMenuStrip_Trigger.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_TriggerAdd, this.toolStripMenuItem_TriggerCopy, this.toolStripMenuItem_TriggerRemove });
		this.contextMenuStrip_Trigger.Name = "contextMenuStrip_Trigger";
		resources.ApplyResources(this.toolStripMenuItem_TriggerAdd, "toolStripMenuItem_TriggerAdd");
		this.toolStripMenuItem_TriggerAdd.Name = "toolStripMenuItem_TriggerAdd";
		this.toolStripMenuItem_TriggerAdd.Click += new System.EventHandler(toolStripMenuItem_TriggerAdd_Click);
		resources.ApplyResources(this.toolStripMenuItem_TriggerCopy, "toolStripMenuItem_TriggerCopy");
		this.toolStripMenuItem_TriggerCopy.Name = "toolStripMenuItem_TriggerCopy";
		this.toolStripMenuItem_TriggerCopy.Click += new System.EventHandler(toolStripMenuItem_TriggerCopy_Click);
		resources.ApplyResources(this.toolStripMenuItem_TriggerRemove, "toolStripMenuItem_TriggerRemove");
		this.toolStripMenuItem_TriggerRemove.Name = "toolStripMenuItem_TriggerRemove";
		this.toolStripMenuItem_TriggerRemove.Click += new System.EventHandler(toolStripMenuItem_TriggerRemove_Click);
		resources.ApplyResources(this.listBox_listOperation, "listBox_listOperation");
		this.listBox_listOperation.ContextMenuStrip = this.contextMenuStrip_Operation;
		this.listBox_listOperation.FormattingEnabled = true;
		this.listBox_listOperation.Name = "listBox_listOperation";
		this.listBox_listOperation.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.listBox_listOperation.SelectedIndexChanged += new System.EventHandler(listBox_listOperation_SelectedIndexChanged);
		resources.ApplyResources(this.contextMenuStrip_Operation, "contextMenuStrip_Operation");
		this.contextMenuStrip_Operation.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.toolStripMenuItem_OperationAdd, this.toolStripMenuItem_OperationCopy, this.toolStripMenuItem_OperationRemove });
		this.contextMenuStrip_Operation.Name = "contextMenuStrip_Operation";
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd, "toolStripMenuItem_OperationAdd");
		this.toolStripMenuItem_OperationAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[103]
		{
			this.toolStripMenuItem_OperationAdd_o_attact, this.toolStripMenuItem_OperationAdd_o_use_skill, this.toolStripMenuItem_OperationAdd_o_talk, this.toolStripMenuItem_OperationAdd_o_reset_hate_list, this.toolStripMenuItem_OperationAdd_o_run_trigger, this.toolStripMenuItem_OperationAdd_o_stop_trigger, this.toolStripMenuItem_OperationAdd_o_active_trigger, this.toolStripMenuItem_OperationAdd_o_create_timer, this.toolStripMenuItem_OperationAdd_o_kill_timer, this.toolStripMenuItem_OperationAdd_o_flee,
			this.toolStripMenuItem_OperationAdd_o_set_hate_to_first, this.toolStripMenuItem_OperationAdd_o_set_hate_to_last, this.toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent, this.toolStripMenuItem_OperationAdd_o_skip_operation, this.toolStripMenuItem_OperationAdd_o_active_controller, this.toolStripMenuItem_OperationAdd_o_set_global, this.toolStripMenuItem_OperationAdd_o_revise_global, this.toolStripMenuItem_OperationAdd_o_summon_monster, this.toolStripMenuItem_OperationAdd_o_walk_along, this.toolStripMenuItem_OperationAdd_o_play_action,
			this.toolStripMenuItem_OperationAdd_o_revise_history, this.toolStripMenuItem_OperationAdd_o_set_history, this.toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points, this.toolStripMenuItem_OperationAdd_o_calc_var, this.toolStripMenuItem_OperationAdd_o_summon_monster_2, this.toolStripMenuItem_OperationAdd_o_walk_along_2, this.toolStripMenuItem_OperationAdd_o_use_skill_2, this.toolStripMenuItem_OperationAdd_o_active_controller_2, this.toolStripMenuItem_OperationAdd_o_deliver_task, this.toolStripMenuItem_OperationAdd_o_summon_mine,
			this.toolStripMenuItem_OperationAdd_o_summon_npc, this.toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region, this.toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list, this.toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region, this.toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param, this.toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param, this.toolStripMenuItem_OperationAdd_o_36, this.toolStripMenuItem_OperationAdd_o_37, this.toolStripMenuItem_OperationAdd_o_38, this.toolStripMenuItem_OperationAdd_o_39,
			this.toolStripMenuItem_OperationAdd_o_40, this.toolStripMenuItem_OperationAdd_o_41, this.toolStripMenuItem_OperationAdd_o_42, this.toolStripMenuItem_OperationAdd_o_43, this.toolStripMenuItem_OperationAdd_o_44, this.toolStripMenuItem_OperationAdd_o_45, this.toolStripMenuItem_OperationAdd_o_46, this.toolStripMenuItem_OperationAdd_o_47, this.toolStripMenuItem_OperationAdd_o_48, this.toolStripMenuItem_OperationAdd_o_49,
			this.toolStripMenuItem_OperationAdd_o_50, this.toolStripMenuItem_OperationAdd_o_51, this.toolStripMenuItem_OperationAdd_o_52, this.toolStripMenuItem_OperationAdd_o_53, this.toolStripMenuItem_OperationAdd_o_54, this.toolStripMenuItem_OperationAdd_o_55, this.toolStripMenuItem_OperationAdd_o_56, this.toolStripMenuItem_OperationAdd_o_57, this.toolStripMenuItem_OperationAdd_o_58, this.toolStripMenuItem_OperationAdd_o_59,
			this.toolStripMenuItem_OperationAdd_o_60, this.toolStripMenuItem_OperationAdd_o_61, this.toolStripMenuItem_OperationAdd_o_62, this.toolStripMenuItem_OperationAdd_o_63, this.toolStripMenuItem_OperationAdd_o_64, this.toolStripMenuItem_OperationAdd_o_65, this.toolStripMenuItem_OperationAdd_o_66, this.toolStripMenuItem_OperationAdd_o_67, this.toolStripMenuItem_OperationAdd_o_68, this.toolStripMenuItem_OperationAdd_o_69,
			this.toolStripMenuItem_OperationAdd_o_70, this.toolStripMenuItem_OperationAdd_o_71, this.toolStripMenuItem_OperationAdd_o_72, this.toolStripMenuItem_OperationAdd_o_73, this.toolStripMenuItem_OperationAdd_o_74, this.toolStripMenuItem_OperationAdd_o_75, this.toolStripMenuItem_OperationAdd_o_76, this.toolStripMenuItem_OperationAdd_o_77, this.toolStripMenuItem_OperationAdd_o_78, this.toolStripMenuItem_OperationAdd_o_79,
			this.toolStripMenuItem_OperationAdd_o_80, this.toolStripMenuItem_OperationAdd_o_81, this.toolStripMenuItem_OperationAdd_o_82, this.toolStripMenuItem_OperationAdd_o_83, this.toolStripMenuItem_OperationAdd_o_84, this.toolStripMenuItem_OperationAdd_o_85, this.toolStripMenuItem_OperationAdd_o_86, this.toolStripMenuItem_OperationAdd_o_87, this.toolStripMenuItem_OperationAdd_o_88, this.toolStripMenuItem_OperationAdd_o_89, 
			this.toolStripMenuItem_OperationAdd_o_90, this.toolStripMenuItem_OperationAdd_o_91, this.toolStripMenuItem_OperationAdd_o_92, this.toolStripMenuItem_OperationAdd_o_93, this.toolStripMenuItem_OperationAdd_o_94, this.toolStripMenuItem_OperationAdd_o_95, this.toolStripMenuItem_OperationAdd_o_96, this.toolStripMenuItem_OperationAdd_o_97, this.toolStripMenuItem_OperationAdd_o_98, this.toolStripMenuItem_OperationAdd_o_99, 
			this.toolStripMenuItem_OperationAdd_o_100, this.toolStripMenuItem_OperationAdd_o_101, this.toolStripMenuItem_OperationAdd_o_102
		});
		this.toolStripMenuItem_OperationAdd.Name = "toolStripMenuItem_OperationAdd";
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_attact, "toolStripMenuItem_OperationAdd_o_attact");
		this.toolStripMenuItem_OperationAdd_o_attact.Name = "toolStripMenuItem_OperationAdd_o_attact";
		this.toolStripMenuItem_OperationAdd_o_attact.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_use_skill, "toolStripMenuItem_OperationAdd_o_use_skill");
		this.toolStripMenuItem_OperationAdd_o_use_skill.Name = "toolStripMenuItem_OperationAdd_o_use_skill";
		this.toolStripMenuItem_OperationAdd_o_use_skill.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_talk, "toolStripMenuItem_OperationAdd_o_talk");
		this.toolStripMenuItem_OperationAdd_o_talk.Name = "toolStripMenuItem_OperationAdd_o_talk";
		this.toolStripMenuItem_OperationAdd_o_talk.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_reset_hate_list, "toolStripMenuItem_OperationAdd_o_reset_hate_list");
		this.toolStripMenuItem_OperationAdd_o_reset_hate_list.Name = "toolStripMenuItem_OperationAdd_o_reset_hate_list";
		this.toolStripMenuItem_OperationAdd_o_reset_hate_list.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_run_trigger, "toolStripMenuItem_OperationAdd_o_run_trigger");
		this.toolStripMenuItem_OperationAdd_o_run_trigger.Name = "toolStripMenuItem_OperationAdd_o_run_trigger";
		this.toolStripMenuItem_OperationAdd_o_run_trigger.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_stop_trigger, "toolStripMenuItem_OperationAdd_o_stop_trigger");
		this.toolStripMenuItem_OperationAdd_o_stop_trigger.Name = "toolStripMenuItem_OperationAdd_o_stop_trigger";
		this.toolStripMenuItem_OperationAdd_o_stop_trigger.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_active_trigger, "toolStripMenuItem_OperationAdd_o_active_trigger");
		this.toolStripMenuItem_OperationAdd_o_active_trigger.Name = "toolStripMenuItem_OperationAdd_o_active_trigger";
		this.toolStripMenuItem_OperationAdd_o_active_trigger.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_create_timer, "toolStripMenuItem_OperationAdd_o_create_timer");
		this.toolStripMenuItem_OperationAdd_o_create_timer.Name = "toolStripMenuItem_OperationAdd_o_create_timer";
		this.toolStripMenuItem_OperationAdd_o_create_timer.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_kill_timer, "toolStripMenuItem_OperationAdd_o_kill_timer");
		this.toolStripMenuItem_OperationAdd_o_kill_timer.Name = "toolStripMenuItem_OperationAdd_o_kill_timer";
		this.toolStripMenuItem_OperationAdd_o_kill_timer.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_flee, "toolStripMenuItem_OperationAdd_o_flee");
		this.toolStripMenuItem_OperationAdd_o_flee.Name = "toolStripMenuItem_OperationAdd_o_flee";
		this.toolStripMenuItem_OperationAdd_o_flee.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_set_hate_to_first, "toolStripMenuItem_OperationAdd_o_set_hate_to_first");
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_first.Name = "toolStripMenuItem_OperationAdd_o_set_hate_to_first";
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_first.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_set_hate_to_last, "toolStripMenuItem_OperationAdd_o_set_hate_to_last");
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_last.Name = "toolStripMenuItem_OperationAdd_o_set_hate_to_last";
		this.toolStripMenuItem_OperationAdd_o_set_hate_to_last.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent, "toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent");
		this.toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent.Name = "toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent";
		this.toolStripMenuItem_OperationAdd_o_set_hate_fifty_percent.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_skip_operation, "toolStripMenuItem_OperationAdd_o_skip_operation");
		this.toolStripMenuItem_OperationAdd_o_skip_operation.Name = "toolStripMenuItem_OperationAdd_o_skip_operation";
		this.toolStripMenuItem_OperationAdd_o_skip_operation.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_active_controller, "toolStripMenuItem_OperationAdd_o_active_controller");
		this.toolStripMenuItem_OperationAdd_o_active_controller.Name = "toolStripMenuItem_OperationAdd_o_active_controller";
		this.toolStripMenuItem_OperationAdd_o_active_controller.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_set_global, "toolStripMenuItem_OperationAdd_o_set_global");
		this.toolStripMenuItem_OperationAdd_o_set_global.Name = "toolStripMenuItem_OperationAdd_o_set_global";
		this.toolStripMenuItem_OperationAdd_o_set_global.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_revise_global, "toolStripMenuItem_OperationAdd_o_revise_global");
		this.toolStripMenuItem_OperationAdd_o_revise_global.Name = "toolStripMenuItem_OperationAdd_o_revise_global";
		this.toolStripMenuItem_OperationAdd_o_revise_global.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_summon_monster, "toolStripMenuItem_OperationAdd_o_summon_monster");
		this.toolStripMenuItem_OperationAdd_o_summon_monster.Name = "toolStripMenuItem_OperationAdd_o_summon_monster";
		this.toolStripMenuItem_OperationAdd_o_summon_monster.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_walk_along, "toolStripMenuItem_OperationAdd_o_walk_along");
		this.toolStripMenuItem_OperationAdd_o_walk_along.Name = "toolStripMenuItem_OperationAdd_o_walk_along";
		this.toolStripMenuItem_OperationAdd_o_walk_along.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_play_action, "toolStripMenuItem_OperationAdd_o_play_action");
		this.toolStripMenuItem_OperationAdd_o_play_action.Name = "toolStripMenuItem_OperationAdd_o_play_action";
		this.toolStripMenuItem_OperationAdd_o_play_action.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_revise_history, "toolStripMenuItem_OperationAdd_o_revise_history");
		this.toolStripMenuItem_OperationAdd_o_revise_history.Name = "toolStripMenuItem_OperationAdd_o_revise_history";
		this.toolStripMenuItem_OperationAdd_o_revise_history.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_set_history, "toolStripMenuItem_OperationAdd_o_set_history");
		this.toolStripMenuItem_OperationAdd_o_set_history.Name = "toolStripMenuItem_OperationAdd_o_set_history";
		this.toolStripMenuItem_OperationAdd_o_set_history.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points, "toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points");
		this.toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points.Name = "toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points";
		this.toolStripMenuItem_OperationAdd_o_deliver_faction_pvp_points.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_calc_var, "toolStripMenuItem_OperationAdd_o_calc_var");
		this.toolStripMenuItem_OperationAdd_o_calc_var.Name = "toolStripMenuItem_OperationAdd_o_calc_var";
		this.toolStripMenuItem_OperationAdd_o_calc_var.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_summon_monster_2, "toolStripMenuItem_OperationAdd_o_summon_monster_2");
		this.toolStripMenuItem_OperationAdd_o_summon_monster_2.Name = "toolStripMenuItem_OperationAdd_o_summon_monster_2";
		this.toolStripMenuItem_OperationAdd_o_summon_monster_2.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_walk_along_2, "toolStripMenuItem_OperationAdd_o_walk_along_2");
		this.toolStripMenuItem_OperationAdd_o_walk_along_2.Name = "toolStripMenuItem_OperationAdd_o_walk_along_2";
		this.toolStripMenuItem_OperationAdd_o_walk_along_2.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_use_skill_2, "toolStripMenuItem_OperationAdd_o_use_skill_2");
		this.toolStripMenuItem_OperationAdd_o_use_skill_2.Name = "toolStripMenuItem_OperationAdd_o_use_skill_2";
		this.toolStripMenuItem_OperationAdd_o_use_skill_2.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_active_controller_2, "toolStripMenuItem_OperationAdd_o_active_controller_2");
		this.toolStripMenuItem_OperationAdd_o_active_controller_2.Name = "toolStripMenuItem_OperationAdd_o_active_controller_2";
		this.toolStripMenuItem_OperationAdd_o_active_controller_2.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_deliver_task, "toolStripMenuItem_OperationAdd_o_deliver_task");
		this.toolStripMenuItem_OperationAdd_o_deliver_task.Name = "toolStripMenuItem_OperationAdd_o_deliver_task";
		this.toolStripMenuItem_OperationAdd_o_deliver_task.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_summon_mine, "toolStripMenuItem_OperationAdd_o_summon_mine");
		this.toolStripMenuItem_OperationAdd_o_summon_mine.Name = "toolStripMenuItem_OperationAdd_o_summon_mine";
		this.toolStripMenuItem_OperationAdd_o_summon_mine.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_summon_npc, "toolStripMenuItem_OperationAdd_o_summon_npc");
		this.toolStripMenuItem_OperationAdd_o_summon_npc.Name = "toolStripMenuItem_OperationAdd_o_summon_npc";
		this.toolStripMenuItem_OperationAdd_o_summon_npc.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region, "toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region");
		this.toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region.Name = "toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region";
		this.toolStripMenuItem_OperationAdd_o_deliver_random_task_in_region.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list, "toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list");
		this.toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list.Name = "toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list";
		this.toolStripMenuItem_OperationAdd_o_deliver_task_in_hate_list.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region, "toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region");
		this.toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region.Name = "toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region";
		this.toolStripMenuItem_OperationAdd_o_clear_tower_task_in_region.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param, "toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param");
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param.Name = "toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param";
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_radius_to_param.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param, "toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param");
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param.Name = "toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param";
		this.toolStripMenuItem_OperationAdd_o_save_player_count_in_region_to_param.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_36, "toolStripMenuItem_OperationAdd_o_36");
		this.toolStripMenuItem_OperationAdd_o_36.Name = "toolStripMenuItem_OperationAdd_o_36";
		this.toolStripMenuItem_OperationAdd_o_36.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_37, "toolStripMenuItem_OperationAdd_o_37");
		this.toolStripMenuItem_OperationAdd_o_37.Name = "toolStripMenuItem_OperationAdd_o_37";
		this.toolStripMenuItem_OperationAdd_o_37.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_38, "toolStripMenuItem_OperationAdd_o_38");
		this.toolStripMenuItem_OperationAdd_o_38.Name = "toolStripMenuItem_OperationAdd_o_38";
		this.toolStripMenuItem_OperationAdd_o_38.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_39, "toolStripMenuItem_OperationAdd_o_39");
		this.toolStripMenuItem_OperationAdd_o_39.Name = "toolStripMenuItem_OperationAdd_o_39";
		this.toolStripMenuItem_OperationAdd_o_39.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_40, "toolStripMenuItem_OperationAdd_o_40");
		this.toolStripMenuItem_OperationAdd_o_40.Name = "toolStripMenuItem_OperationAdd_o_40";
		this.toolStripMenuItem_OperationAdd_o_40.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_41, "toolStripMenuItem_OperationAdd_o_41");
		this.toolStripMenuItem_OperationAdd_o_41.Name = "toolStripMenuItem_OperationAdd_o_41";
		this.toolStripMenuItem_OperationAdd_o_41.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_42, "toolStripMenuItem_OperationAdd_o_42");
		this.toolStripMenuItem_OperationAdd_o_42.Name = "toolStripMenuItem_OperationAdd_o_42";
		this.toolStripMenuItem_OperationAdd_o_42.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_43, "toolStripMenuItem_OperationAdd_o_43");
		this.toolStripMenuItem_OperationAdd_o_43.Name = "toolStripMenuItem_OperationAdd_o_43";
		this.toolStripMenuItem_OperationAdd_o_43.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_44, "toolStripMenuItem_OperationAdd_o_44");
		this.toolStripMenuItem_OperationAdd_o_44.Name = "toolStripMenuItem_OperationAdd_o_44";
		this.toolStripMenuItem_OperationAdd_o_44.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_45, "toolStripMenuItem_OperationAdd_o_45");
		this.toolStripMenuItem_OperationAdd_o_45.Name = "toolStripMenuItem_OperationAdd_o_45";
		this.toolStripMenuItem_OperationAdd_o_45.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_46, "toolStripMenuItem_OperationAdd_o_46");
		this.toolStripMenuItem_OperationAdd_o_46.Name = "toolStripMenuItem_OperationAdd_o_46";
		this.toolStripMenuItem_OperationAdd_o_46.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_47, "toolStripMenuItem_OperationAdd_o_47");
		this.toolStripMenuItem_OperationAdd_o_47.Name = "toolStripMenuItem_OperationAdd_o_47";
		this.toolStripMenuItem_OperationAdd_o_47.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_48, "toolStripMenuItem_OperationAdd_o_48");
		this.toolStripMenuItem_OperationAdd_o_48.Name = "toolStripMenuItem_OperationAdd_o_48";
		this.toolStripMenuItem_OperationAdd_o_48.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_49, "toolStripMenuItem_OperationAdd_o_49");
		this.toolStripMenuItem_OperationAdd_o_49.Name = "toolStripMenuItem_OperationAdd_o_49";
		this.toolStripMenuItem_OperationAdd_o_49.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_50, "toolStripMenuItem_OperationAdd_o_50");
		this.toolStripMenuItem_OperationAdd_o_50.Name = "toolStripMenuItem_OperationAdd_o_50";
		this.toolStripMenuItem_OperationAdd_o_50.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_51, "toolStripMenuItem_OperationAdd_o_51");
		this.toolStripMenuItem_OperationAdd_o_51.Name = "toolStripMenuItem_OperationAdd_o_51";
		this.toolStripMenuItem_OperationAdd_o_51.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_52, "toolStripMenuItem_OperationAdd_o_52");
		this.toolStripMenuItem_OperationAdd_o_52.Name = "toolStripMenuItem_OperationAdd_o_52";
		this.toolStripMenuItem_OperationAdd_o_52.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_53, "toolStripMenuItem_OperationAdd_o_53");
		this.toolStripMenuItem_OperationAdd_o_53.Name = "toolStripMenuItem_OperationAdd_o_53";
		this.toolStripMenuItem_OperationAdd_o_53.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_54, "toolStripMenuItem_OperationAdd_o_54");
		this.toolStripMenuItem_OperationAdd_o_54.Name = "toolStripMenuItem_OperationAdd_o_54";
		this.toolStripMenuItem_OperationAdd_o_54.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_55, "toolStripMenuItem_OperationAdd_o_55");
		this.toolStripMenuItem_OperationAdd_o_55.Name = "toolStripMenuItem_OperationAdd_o_55";
		this.toolStripMenuItem_OperationAdd_o_55.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_56, "toolStripMenuItem_OperationAdd_o_56");
		this.toolStripMenuItem_OperationAdd_o_56.Name = "toolStripMenuItem_OperationAdd_o_56";
		this.toolStripMenuItem_OperationAdd_o_56.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_57, "toolStripMenuItem_OperationAdd_o_57");
		this.toolStripMenuItem_OperationAdd_o_57.Name = "toolStripMenuItem_OperationAdd_o_57";
		this.toolStripMenuItem_OperationAdd_o_57.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_58, "toolStripMenuItem_OperationAdd_o_58");
		this.toolStripMenuItem_OperationAdd_o_58.Name = "toolStripMenuItem_OperationAdd_o_58";
		this.toolStripMenuItem_OperationAdd_o_58.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_59, "toolStripMenuItem_OperationAdd_o_59");
		this.toolStripMenuItem_OperationAdd_o_59.Name = "toolStripMenuItem_OperationAdd_o_59";
		this.toolStripMenuItem_OperationAdd_o_59.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_60, "toolStripMenuItem_OperationAdd_o_60");
		this.toolStripMenuItem_OperationAdd_o_60.Name = "toolStripMenuItem_OperationAdd_o_60";
		this.toolStripMenuItem_OperationAdd_o_60.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_61, "toolStripMenuItem_OperationAdd_o_61");
		this.toolStripMenuItem_OperationAdd_o_61.Name = "toolStripMenuItem_OperationAdd_o_61";
		this.toolStripMenuItem_OperationAdd_o_61.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_62, "toolStripMenuItem_OperationAdd_o_62");
		this.toolStripMenuItem_OperationAdd_o_62.Name = "toolStripMenuItem_OperationAdd_o_62";
		this.toolStripMenuItem_OperationAdd_o_62.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_63, "toolStripMenuItem_OperationAdd_o_63");
		this.toolStripMenuItem_OperationAdd_o_63.Name = "toolStripMenuItem_OperationAdd_o_63";
		this.toolStripMenuItem_OperationAdd_o_63.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_64, "toolStripMenuItem_OperationAdd_o_64");
		this.toolStripMenuItem_OperationAdd_o_64.Name = "toolStripMenuItem_OperationAdd_o_64";
		this.toolStripMenuItem_OperationAdd_o_64.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_65, "toolStripMenuItem_OperationAdd_o_65");
		this.toolStripMenuItem_OperationAdd_o_65.Name = "toolStripMenuItem_OperationAdd_o_65";
		this.toolStripMenuItem_OperationAdd_o_65.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_66, "toolStripMenuItem_OperationAdd_o_66");
		this.toolStripMenuItem_OperationAdd_o_66.Name = "toolStripMenuItem_OperationAdd_o_66";
		this.toolStripMenuItem_OperationAdd_o_66.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_67, "toolStripMenuItem_OperationAdd_o_67");
		this.toolStripMenuItem_OperationAdd_o_67.Name = "toolStripMenuItem_OperationAdd_o_67";
		this.toolStripMenuItem_OperationAdd_o_67.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_68, "toolStripMenuItem_OperationAdd_o_68");
		this.toolStripMenuItem_OperationAdd_o_68.Name = "toolStripMenuItem_OperationAdd_o_68";
		this.toolStripMenuItem_OperationAdd_o_68.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_69, "toolStripMenuItem_OperationAdd_o_69");
		this.toolStripMenuItem_OperationAdd_o_69.Name = "toolStripMenuItem_OperationAdd_o_69";
		this.toolStripMenuItem_OperationAdd_o_69.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_70, "toolStripMenuItem_OperationAdd_o_70");
		this.toolStripMenuItem_OperationAdd_o_70.Name = "toolStripMenuItem_OperationAdd_o_70";
		this.toolStripMenuItem_OperationAdd_o_70.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_71, "toolStripMenuItem_OperationAdd_o_71");
		this.toolStripMenuItem_OperationAdd_o_71.Name = "toolStripMenuItem_OperationAdd_o_71";
		this.toolStripMenuItem_OperationAdd_o_71.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_72, "toolStripMenuItem_OperationAdd_o_72");
		this.toolStripMenuItem_OperationAdd_o_72.Name = "toolStripMenuItem_OperationAdd_o_72";
		this.toolStripMenuItem_OperationAdd_o_72.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_73, "toolStripMenuItem_OperationAdd_o_73");
		this.toolStripMenuItem_OperationAdd_o_73.Name = "toolStripMenuItem_OperationAdd_o_73";
		this.toolStripMenuItem_OperationAdd_o_73.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_74, "toolStripMenuItem_OperationAdd_o_74");
		this.toolStripMenuItem_OperationAdd_o_74.Name = "toolStripMenuItem_OperationAdd_o_74";
		this.toolStripMenuItem_OperationAdd_o_74.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_75, "toolStripMenuItem_OperationAdd_o_75");
		this.toolStripMenuItem_OperationAdd_o_75.Name = "toolStripMenuItem_OperationAdd_o_75";
		this.toolStripMenuItem_OperationAdd_o_75.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_76, "toolStripMenuItem_OperationAdd_o_76");
		this.toolStripMenuItem_OperationAdd_o_76.Name = "toolStripMenuItem_OperationAdd_o_76";
		this.toolStripMenuItem_OperationAdd_o_76.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_77, "toolStripMenuItem_OperationAdd_o_77");
		this.toolStripMenuItem_OperationAdd_o_77.Name = "toolStripMenuItem_OperationAdd_o_77";
		this.toolStripMenuItem_OperationAdd_o_77.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_78, "toolStripMenuItem_OperationAdd_o_78");
		this.toolStripMenuItem_OperationAdd_o_78.Name = "toolStripMenuItem_OperationAdd_o_78";
		this.toolStripMenuItem_OperationAdd_o_78.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_79, "toolStripMenuItem_OperationAdd_o_79");
		this.toolStripMenuItem_OperationAdd_o_79.Name = "toolStripMenuItem_OperationAdd_o_79";
		this.toolStripMenuItem_OperationAdd_o_79.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_80, "toolStripMenuItem_OperationAdd_o_80");
		this.toolStripMenuItem_OperationAdd_o_80.Name = "toolStripMenuItem_OperationAdd_o_80";
		this.toolStripMenuItem_OperationAdd_o_80.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_81, "toolStripMenuItem_OperationAdd_o_81");
		this.toolStripMenuItem_OperationAdd_o_81.Name = "toolStripMenuItem_OperationAdd_o_81";
		this.toolStripMenuItem_OperationAdd_o_81.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_82, "toolStripMenuItem_OperationAdd_o_82");
		this.toolStripMenuItem_OperationAdd_o_82.Name = "toolStripMenuItem_OperationAdd_o_82";
		this.toolStripMenuItem_OperationAdd_o_82.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_83, "toolStripMenuItem_OperationAdd_o_83");
		this.toolStripMenuItem_OperationAdd_o_83.Name = "toolStripMenuItem_OperationAdd_o_83";
		this.toolStripMenuItem_OperationAdd_o_83.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_84, "toolStripMenuItem_OperationAdd_o_84");
		this.toolStripMenuItem_OperationAdd_o_84.Name = "toolStripMenuItem_OperationAdd_o_84";
		this.toolStripMenuItem_OperationAdd_o_84.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_85, "toolStripMenuItem_OperationAdd_o_85");
		this.toolStripMenuItem_OperationAdd_o_85.Name = "toolStripMenuItem_OperationAdd_o_85";
		this.toolStripMenuItem_OperationAdd_o_85.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_86, "toolStripMenuItem_OperationAdd_o_86");
		this.toolStripMenuItem_OperationAdd_o_86.Name = "toolStripMenuItem_OperationAdd_o_86";
		this.toolStripMenuItem_OperationAdd_o_86.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_87, "toolStripMenuItem_OperationAdd_o_87");
		this.toolStripMenuItem_OperationAdd_o_87.Name = "toolStripMenuItem_OperationAdd_o_87";
		this.toolStripMenuItem_OperationAdd_o_87.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_88, "toolStripMenuItem_OperationAdd_o_88");
		this.toolStripMenuItem_OperationAdd_o_88.Name = "toolStripMenuItem_OperationAdd_o_88";
		this.toolStripMenuItem_OperationAdd_o_88.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_89, "toolStripMenuItem_OperationAdd_o_89");
		this.toolStripMenuItem_OperationAdd_o_89.Name = "toolStripMenuItem_OperationAdd_o_89";
		this.toolStripMenuItem_OperationAdd_o_89.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_90, "toolStripMenuItem_OperationAdd_o_90");
		this.toolStripMenuItem_OperationAdd_o_90.Name = "toolStripMenuItem_OperationAdd_o_90";
		this.toolStripMenuItem_OperationAdd_o_90.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_91, "toolStripMenuItem_OperationAdd_o_91");
		this.toolStripMenuItem_OperationAdd_o_91.Name = "toolStripMenuItem_OperationAdd_o_91";
		this.toolStripMenuItem_OperationAdd_o_91.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_92, "toolStripMenuItem_OperationAdd_o_92");
		this.toolStripMenuItem_OperationAdd_o_92.Name = "toolStripMenuItem_OperationAdd_o_92";
		this.toolStripMenuItem_OperationAdd_o_92.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_93, "toolStripMenuItem_OperationAdd_o_93");
		this.toolStripMenuItem_OperationAdd_o_93.Name = "toolStripMenuItem_OperationAdd_o_93";
		this.toolStripMenuItem_OperationAdd_o_93.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_94, "toolStripMenuItem_OperationAdd_o_94");
		this.toolStripMenuItem_OperationAdd_o_94.Name = "toolStripMenuItem_OperationAdd_o_94";
		this.toolStripMenuItem_OperationAdd_o_94.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_95, "toolStripMenuItem_OperationAdd_o_95");
		this.toolStripMenuItem_OperationAdd_o_95.Name = "toolStripMenuItem_OperationAdd_o_95";
		this.toolStripMenuItem_OperationAdd_o_95.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_96, "toolStripMenuItem_OperationAdd_o_96");
		this.toolStripMenuItem_OperationAdd_o_96.Name = "toolStripMenuItem_OperationAdd_o_96";
		this.toolStripMenuItem_OperationAdd_o_96.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_97, "toolStripMenuItem_OperationAdd_o_97");
		this.toolStripMenuItem_OperationAdd_o_97.Name = "toolStripMenuItem_OperationAdd_o_97";
		this.toolStripMenuItem_OperationAdd_o_97.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_98, "toolStripMenuItem_OperationAdd_o_98");
		this.toolStripMenuItem_OperationAdd_o_98.Name = "toolStripMenuItem_OperationAdd_o_98";
		this.toolStripMenuItem_OperationAdd_o_98.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_99, "toolStripMenuItem_OperationAdd_o_99");
		this.toolStripMenuItem_OperationAdd_o_99.Name = "toolStripMenuItem_OperationAdd_o_99";
		this.toolStripMenuItem_OperationAdd_o_99.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_100, "toolStripMenuItem_OperationAdd_o_100");
		this.toolStripMenuItem_OperationAdd_o_100.Name = "toolStripMenuItem_OperationAdd_o_100";
		this.toolStripMenuItem_OperationAdd_o_100.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_101, "toolStripMenuItem_OperationAdd_o_101");
		this.toolStripMenuItem_OperationAdd_o_101.Name = "toolStripMenuItem_OperationAdd_o_101";
		this.toolStripMenuItem_OperationAdd_o_101.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationAdd_o_102, "toolStripMenuItem_OperationAdd_o_102");
		this.toolStripMenuItem_OperationAdd_o_102.Name = "toolStripMenuItem_OperationAdd_o_102";
		this.toolStripMenuItem_OperationAdd_o_102.Click += new System.EventHandler(OperationAdd);
		resources.ApplyResources(this.toolStripMenuItem_OperationCopy, "toolStripMenuItem_OperationCopy");
		this.toolStripMenuItem_OperationCopy.Name = "toolStripMenuItem_OperationCopy";
		this.toolStripMenuItem_OperationCopy.Click += new System.EventHandler(toolStripMenuItem_OperationCopy_Click);
		resources.ApplyResources(this.toolStripMenuItem_OperationRemove, "toolStripMenuItem_OperationRemove");
		this.toolStripMenuItem_OperationRemove.Name = "toolStripMenuItem_OperationRemove";
		this.toolStripMenuItem_OperationRemove.Click += new System.EventHandler(OperationRemove);
		resources.ApplyResources(this.propertyGrid_Operation, "propertyGrid_Operation");
		this.propertyGrid_Operation.Name = "propertyGrid_Operation";
		this.propertyGrid_Operation.PropertySort = System.Windows.Forms.PropertySort.NoSort;
		this.propertyGrid_Operation.ToolbarVisible = false;
		this.propertyGrid_Operation.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(propertyGrid_Operation_PropertyValueChanged);
		resources.ApplyResources(this.propertyGrid_rootConditon, "propertyGrid_rootConditon");
		this.propertyGrid_rootConditon.ContextMenuStrip = this.contextMenuStrip_rootConditon;
		this.propertyGrid_rootConditon.Name = "propertyGrid_rootConditon";
		this.propertyGrid_rootConditon.PropertySort = System.Windows.Forms.PropertySort.NoSort;
		this.propertyGrid_rootConditon.ToolbarVisible = false;
		this.propertyGrid_rootConditon.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(propertyGrid_rootConditon_PropertyValueChanged);
		resources.ApplyResources(this.contextMenuStrip_rootConditon, "contextMenuStrip_rootConditon");
		this.contextMenuStrip_rootConditon.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripMenuItem_ConditionAdd, this.toolStripMenuItem_ConditonRemove });
		this.contextMenuStrip_rootConditon.Name = "contextMenuStrip1";
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd, "toolStripMenuItem_ConditionAdd");
		this.toolStripMenuItem_ConditionAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[47]
		{
			this.toolStripMenuItem_ConditionAdd_c_time_come, this.toolStripMenuItem_ConditionAdd_c_hp_less, this.toolStripMenuItem_ConditionAdd_c_start_attack, this.toolStripMenuItem_ConditionAdd_c_random, this.toolStripMenuItem_ConditionAdd_c_kill_player, this.toolStripMenuItem_ConditionAdd_c_not, this.toolStripMenuItem_ConditionAdd_c_or, this.toolStripMenuItem_ConditionAdd_c_and, this.toolStripMenuItem_ConditionAdd_c_died, this.toolStripMenuItem_ConditionAdd_c_plus,
			this.toolStripMenuItem_ConditionAdd_c_minus, this.toolStripMenuItem_ConditionAdd_c_multiply, this.toolStripMenuItem_ConditionAdd_c_divide, this.toolStripMenuItem_ConditionAdd_c_great, this.toolStripMenuItem_ConditionAdd_c_less, this.toolStripMenuItem_ConditionAdd_c_equ, this.toolStripMenuItem_ConditionAdd_c_var, this.toolStripMenuItem_ConditionAdd_c_constant, this.toolStripMenuItem_ConditionAdd_c_be_hurt, this.toolStripMenuItem_ConditionAdd_c_reach_end,
			this.toolStripMenuItem_ConditionAdd_c_at_history_stage, this.toolStripMenuItem_ConditionAdd_c_history_value, this.toolStripMenuItem_ConditionAdd_c_stop_fight, this.toolStripMenuItem_ConditionAdd_c_local_var, this.toolStripMenuItem_ConditionAdd_c_reach_end_2, this.toolStripMenuItem_ConditionAdd_c_has_filter, this.toolStripMenuItem_ConditionAdd_c_room_index, this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius, this.toolStripMenuItem_ConditionAdd_c_player_count_in_region, this.toolStripMenuItem_ConditionAdd_c_29,
			this.toolStripMenuItem_ConditionAdd_c_30, this.toolStripMenuItem_ConditionAdd_c_31, this.toolStripMenuItem_ConditionAdd_c_32, this.toolStripMenuItem_ConditionAdd_c_33, this.toolStripMenuItem_ConditionAdd_c_34, this.toolStripMenuItem_ConditionAdd_c_35, this.toolStripMenuItem_ConditionAdd_c_36, this.toolStripMenuItem_ConditionAdd_c_37, this.toolStripMenuItem_ConditionAdd_c_38, this.toolStripMenuItem_ConditionAdd_c_39,
			this.toolStripMenuItem_ConditionAdd_c_40, this.toolStripMenuItem_ConditionAdd_c_41, this.toolStripMenuItem_ConditionAdd_c_42, this.toolStripMenuItem_ConditionAdd_c_43, this.toolStripMenuItem_ConditionAdd_c_44, this.toolStripMenuItem_ConditionAdd_c_45, this.toolStripMenuItem_ConditionAdd_c_46
		});
		this.toolStripMenuItem_ConditionAdd.Name = "toolStripMenuItem_ConditionAdd";
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_time_come, "toolStripMenuItem_ConditionAdd_c_time_come");
		this.toolStripMenuItem_ConditionAdd_c_time_come.Name = "toolStripMenuItem_ConditionAdd_c_time_come";
		this.toolStripMenuItem_ConditionAdd_c_time_come.Tag = "0";
		this.toolStripMenuItem_ConditionAdd_c_time_come.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_hp_less, "toolStripMenuItem_ConditionAdd_c_hp_less");
		this.toolStripMenuItem_ConditionAdd_c_hp_less.Name = "toolStripMenuItem_ConditionAdd_c_hp_less";
		this.toolStripMenuItem_ConditionAdd_c_hp_less.Tag = "1";
		this.toolStripMenuItem_ConditionAdd_c_hp_less.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_start_attack, "toolStripMenuItem_ConditionAdd_c_start_attack");
		this.toolStripMenuItem_ConditionAdd_c_start_attack.Name = "toolStripMenuItem_ConditionAdd_c_start_attack";
		this.toolStripMenuItem_ConditionAdd_c_start_attack.Tag = "2";
		this.toolStripMenuItem_ConditionAdd_c_start_attack.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_random, "toolStripMenuItem_ConditionAdd_c_random");
		this.toolStripMenuItem_ConditionAdd_c_random.Name = "toolStripMenuItem_ConditionAdd_c_random";
		this.toolStripMenuItem_ConditionAdd_c_random.Tag = "3";
		this.toolStripMenuItem_ConditionAdd_c_random.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_kill_player, "toolStripMenuItem_ConditionAdd_c_kill_player");
		this.toolStripMenuItem_ConditionAdd_c_kill_player.Name = "toolStripMenuItem_ConditionAdd_c_kill_player";
		this.toolStripMenuItem_ConditionAdd_c_kill_player.Tag = "4";
		this.toolStripMenuItem_ConditionAdd_c_kill_player.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_not, "toolStripMenuItem_ConditionAdd_c_not");
		this.toolStripMenuItem_ConditionAdd_c_not.Name = "toolStripMenuItem_ConditionAdd_c_not";
		this.toolStripMenuItem_ConditionAdd_c_not.Tag = "5";
		this.toolStripMenuItem_ConditionAdd_c_not.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_or, "toolStripMenuItem_ConditionAdd_c_or");
		this.toolStripMenuItem_ConditionAdd_c_or.Name = "toolStripMenuItem_ConditionAdd_c_or";
		this.toolStripMenuItem_ConditionAdd_c_or.Tag = "6";
		this.toolStripMenuItem_ConditionAdd_c_or.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_and, "toolStripMenuItem_ConditionAdd_c_and");
		this.toolStripMenuItem_ConditionAdd_c_and.Name = "toolStripMenuItem_ConditionAdd_c_and";
		this.toolStripMenuItem_ConditionAdd_c_and.Tag = "7";
		this.toolStripMenuItem_ConditionAdd_c_and.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_died, "toolStripMenuItem_ConditionAdd_c_died");
		this.toolStripMenuItem_ConditionAdd_c_died.Name = "toolStripMenuItem_ConditionAdd_c_died";
		this.toolStripMenuItem_ConditionAdd_c_died.Tag = "8";
		this.toolStripMenuItem_ConditionAdd_c_died.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_plus, "toolStripMenuItem_ConditionAdd_c_plus");
		this.toolStripMenuItem_ConditionAdd_c_plus.Name = "toolStripMenuItem_ConditionAdd_c_plus";
		this.toolStripMenuItem_ConditionAdd_c_plus.Tag = "9";
		this.toolStripMenuItem_ConditionAdd_c_plus.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_minus, "toolStripMenuItem_ConditionAdd_c_minus");
		this.toolStripMenuItem_ConditionAdd_c_minus.Name = "toolStripMenuItem_ConditionAdd_c_minus";
		this.toolStripMenuItem_ConditionAdd_c_minus.Tag = "10";
		this.toolStripMenuItem_ConditionAdd_c_minus.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_multiply, "toolStripMenuItem_ConditionAdd_c_multiply");
		this.toolStripMenuItem_ConditionAdd_c_multiply.Name = "toolStripMenuItem_ConditionAdd_c_multiply";
		this.toolStripMenuItem_ConditionAdd_c_multiply.Tag = "11";
		this.toolStripMenuItem_ConditionAdd_c_multiply.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_divide, "toolStripMenuItem_ConditionAdd_c_divide");
		this.toolStripMenuItem_ConditionAdd_c_divide.Name = "toolStripMenuItem_ConditionAdd_c_divide";
		this.toolStripMenuItem_ConditionAdd_c_divide.Tag = "12";
		this.toolStripMenuItem_ConditionAdd_c_divide.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_great, "toolStripMenuItem_ConditionAdd_c_great");
		this.toolStripMenuItem_ConditionAdd_c_great.Name = "toolStripMenuItem_ConditionAdd_c_great";
		this.toolStripMenuItem_ConditionAdd_c_great.Tag = "13";
		this.toolStripMenuItem_ConditionAdd_c_great.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_less, "toolStripMenuItem_ConditionAdd_c_less");
		this.toolStripMenuItem_ConditionAdd_c_less.Name = "toolStripMenuItem_ConditionAdd_c_less";
		this.toolStripMenuItem_ConditionAdd_c_less.Tag = "14";
		this.toolStripMenuItem_ConditionAdd_c_less.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_equ, "toolStripMenuItem_ConditionAdd_c_equ");
		this.toolStripMenuItem_ConditionAdd_c_equ.Name = "toolStripMenuItem_ConditionAdd_c_equ";
		this.toolStripMenuItem_ConditionAdd_c_equ.Tag = "15";
		this.toolStripMenuItem_ConditionAdd_c_equ.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_var, "toolStripMenuItem_ConditionAdd_c_var");
		this.toolStripMenuItem_ConditionAdd_c_var.Name = "toolStripMenuItem_ConditionAdd_c_var";
		this.toolStripMenuItem_ConditionAdd_c_var.Tag = "16";
		this.toolStripMenuItem_ConditionAdd_c_var.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_constant, "toolStripMenuItem_ConditionAdd_c_constant");
		this.toolStripMenuItem_ConditionAdd_c_constant.Name = "toolStripMenuItem_ConditionAdd_c_constant";
		this.toolStripMenuItem_ConditionAdd_c_constant.Tag = "17";
		this.toolStripMenuItem_ConditionAdd_c_constant.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_be_hurt, "toolStripMenuItem_ConditionAdd_c_be_hurt");
		this.toolStripMenuItem_ConditionAdd_c_be_hurt.Name = "toolStripMenuItem_ConditionAdd_c_be_hurt";
		this.toolStripMenuItem_ConditionAdd_c_be_hurt.Tag = "18";
		this.toolStripMenuItem_ConditionAdd_c_be_hurt.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_reach_end, "toolStripMenuItem_ConditionAdd_c_reach_end");
		this.toolStripMenuItem_ConditionAdd_c_reach_end.Name = "toolStripMenuItem_ConditionAdd_c_reach_end";
		this.toolStripMenuItem_ConditionAdd_c_reach_end.Tag = "19";
		this.toolStripMenuItem_ConditionAdd_c_reach_end.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_at_history_stage, "toolStripMenuItem_ConditionAdd_c_at_history_stage");
		this.toolStripMenuItem_ConditionAdd_c_at_history_stage.Name = "toolStripMenuItem_ConditionAdd_c_at_history_stage";
		this.toolStripMenuItem_ConditionAdd_c_at_history_stage.Tag = "20";
		this.toolStripMenuItem_ConditionAdd_c_at_history_stage.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_history_value, "toolStripMenuItem_ConditionAdd_c_history_value");
		this.toolStripMenuItem_ConditionAdd_c_history_value.Name = "toolStripMenuItem_ConditionAdd_c_history_value";
		this.toolStripMenuItem_ConditionAdd_c_history_value.Tag = "21";
		this.toolStripMenuItem_ConditionAdd_c_history_value.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_stop_fight, "toolStripMenuItem_ConditionAdd_c_stop_fight");
		this.toolStripMenuItem_ConditionAdd_c_stop_fight.Name = "toolStripMenuItem_ConditionAdd_c_stop_fight";
		this.toolStripMenuItem_ConditionAdd_c_stop_fight.Tag = "22";
		this.toolStripMenuItem_ConditionAdd_c_stop_fight.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_local_var, "toolStripMenuItem_ConditionAdd_c_local_var");
		this.toolStripMenuItem_ConditionAdd_c_local_var.Name = "toolStripMenuItem_ConditionAdd_c_local_var";
		this.toolStripMenuItem_ConditionAdd_c_local_var.Tag = "23";
		this.toolStripMenuItem_ConditionAdd_c_local_var.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_reach_end_2, "toolStripMenuItem_ConditionAdd_c_reach_end_2");
		this.toolStripMenuItem_ConditionAdd_c_reach_end_2.Name = "toolStripMenuItem_ConditionAdd_c_reach_end_2";
		this.toolStripMenuItem_ConditionAdd_c_reach_end_2.Tag = "24";
		this.toolStripMenuItem_ConditionAdd_c_reach_end_2.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_has_filter, "toolStripMenuItem_ConditionAdd_c_has_filter");
		this.toolStripMenuItem_ConditionAdd_c_has_filter.Name = "toolStripMenuItem_ConditionAdd_c_has_filter";
		this.toolStripMenuItem_ConditionAdd_c_has_filter.Tag = "25";
		this.toolStripMenuItem_ConditionAdd_c_has_filter.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_room_index, "toolStripMenuItem_ConditionAdd_c_room_index");
		this.toolStripMenuItem_ConditionAdd_c_room_index.Name = "toolStripMenuItem_ConditionAdd_c_room_index";
		this.toolStripMenuItem_ConditionAdd_c_room_index.Tag = "26";
		this.toolStripMenuItem_ConditionAdd_c_room_index.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius, "toolStripMenuItem_ConditionAdd_c_player_count_in_radius");
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius.Name = "toolStripMenuItem_ConditionAdd_c_player_count_in_radius";
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius.Tag = "27";
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_radius.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_player_count_in_region, "toolStripMenuItem_ConditionAdd_c_player_count_in_region");
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_region.Name = "toolStripMenuItem_ConditionAdd_c_player_count_in_region";
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_region.Tag = "28";
		this.toolStripMenuItem_ConditionAdd_c_player_count_in_region.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_29, "toolStripMenuItem_ConditionAdd_c_29");
		this.toolStripMenuItem_ConditionAdd_c_29.Name = "toolStripMenuItem_ConditionAdd_c_29";
		this.toolStripMenuItem_ConditionAdd_c_29.Tag = "29";
		this.toolStripMenuItem_ConditionAdd_c_29.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_30, "toolStripMenuItem_ConditionAdd_c_30");
		this.toolStripMenuItem_ConditionAdd_c_30.Name = "toolStripMenuItem_ConditionAdd_c_30";
		this.toolStripMenuItem_ConditionAdd_c_30.Tag = "30";
		this.toolStripMenuItem_ConditionAdd_c_30.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_31, "toolStripMenuItem_ConditionAdd_c_31");
		this.toolStripMenuItem_ConditionAdd_c_31.Name = "toolStripMenuItem_ConditionAdd_c_31";
		this.toolStripMenuItem_ConditionAdd_c_31.Tag = "31";
		this.toolStripMenuItem_ConditionAdd_c_31.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_32, "toolStripMenuItem_ConditionAdd_c_32");
		this.toolStripMenuItem_ConditionAdd_c_32.Name = "toolStripMenuItem_ConditionAdd_c_32";
		this.toolStripMenuItem_ConditionAdd_c_32.Tag = "32";
		this.toolStripMenuItem_ConditionAdd_c_32.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_33, "toolStripMenuItem_ConditionAdd_c_33");
		this.toolStripMenuItem_ConditionAdd_c_33.Name = "toolStripMenuItem_ConditionAdd_c_33";
		this.toolStripMenuItem_ConditionAdd_c_33.Tag = "33";
		this.toolStripMenuItem_ConditionAdd_c_33.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_34, "toolStripMenuItem_ConditionAdd_c_34");
		this.toolStripMenuItem_ConditionAdd_c_34.Name = "toolStripMenuItem_ConditionAdd_c_34";
		this.toolStripMenuItem_ConditionAdd_c_34.Tag = "34";
		this.toolStripMenuItem_ConditionAdd_c_34.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_35, "toolStripMenuItem_ConditionAdd_c_35");
		this.toolStripMenuItem_ConditionAdd_c_35.Name = "toolStripMenuItem_ConditionAdd_c_35";
		this.toolStripMenuItem_ConditionAdd_c_35.Tag = "35";
		this.toolStripMenuItem_ConditionAdd_c_35.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_36, "toolStripMenuItem_ConditionAdd_c_36");
		this.toolStripMenuItem_ConditionAdd_c_36.Name = "toolStripMenuItem_ConditionAdd_c_36";
		this.toolStripMenuItem_ConditionAdd_c_36.Tag = "36";
		this.toolStripMenuItem_ConditionAdd_c_36.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_37, "toolStripMenuItem_ConditionAdd_c_37");
		this.toolStripMenuItem_ConditionAdd_c_37.Name = "toolStripMenuItem_ConditionAdd_c_37";
		this.toolStripMenuItem_ConditionAdd_c_37.Tag = "37";
		this.toolStripMenuItem_ConditionAdd_c_37.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_38, "toolStripMenuItem_ConditionAdd_c_38");
		this.toolStripMenuItem_ConditionAdd_c_38.Name = "toolStripMenuItem_ConditionAdd_c_38";
		this.toolStripMenuItem_ConditionAdd_c_38.Tag = "38";
		this.toolStripMenuItem_ConditionAdd_c_38.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_39, "toolStripMenuItem_ConditionAdd_c_39");
		this.toolStripMenuItem_ConditionAdd_c_39.Name = "toolStripMenuItem_ConditionAdd_c_39";
		this.toolStripMenuItem_ConditionAdd_c_39.Tag = "39";
		this.toolStripMenuItem_ConditionAdd_c_39.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_40, "toolStripMenuItem_ConditionAdd_c_40");
		this.toolStripMenuItem_ConditionAdd_c_40.Name = "toolStripMenuItem_ConditionAdd_c_40";
		this.toolStripMenuItem_ConditionAdd_c_40.Tag = "40";
		this.toolStripMenuItem_ConditionAdd_c_40.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_41, "toolStripMenuItem_ConditionAdd_c_41");
		this.toolStripMenuItem_ConditionAdd_c_41.Name = "toolStripMenuItem_ConditionAdd_c_41";
		this.toolStripMenuItem_ConditionAdd_c_41.Tag = "41";
		this.toolStripMenuItem_ConditionAdd_c_41.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_42, "toolStripMenuItem_ConditionAdd_c_42");
		this.toolStripMenuItem_ConditionAdd_c_42.Name = "toolStripMenuItem_ConditionAdd_c_42";
		this.toolStripMenuItem_ConditionAdd_c_42.Tag = "42";
		this.toolStripMenuItem_ConditionAdd_c_42.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_43, "toolStripMenuItem_ConditionAdd_c_43");
		this.toolStripMenuItem_ConditionAdd_c_43.Name = "toolStripMenuItem_ConditionAdd_c_43";
		this.toolStripMenuItem_ConditionAdd_c_43.Tag = "43";
		this.toolStripMenuItem_ConditionAdd_c_43.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_44, "toolStripMenuItem_ConditionAdd_c_44");
		this.toolStripMenuItem_ConditionAdd_c_44.Name = "toolStripMenuItem_ConditionAdd_c_44";
		this.toolStripMenuItem_ConditionAdd_c_44.Tag = "44";
		this.toolStripMenuItem_ConditionAdd_c_44.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_45, "toolStripMenuItem_ConditionAdd_c_45");
		this.toolStripMenuItem_ConditionAdd_c_45.Name = "toolStripMenuItem_ConditionAdd_c_45";
		this.toolStripMenuItem_ConditionAdd_c_45.Tag = "45";
		this.toolStripMenuItem_ConditionAdd_c_45.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditionAdd_c_46, "toolStripMenuItem_ConditionAdd_c_46");
		this.toolStripMenuItem_ConditionAdd_c_46.Name = "toolStripMenuItem_ConditionAdd_c_46";
		this.toolStripMenuItem_ConditionAdd_c_46.Tag = "46";
		this.toolStripMenuItem_ConditionAdd_c_46.Click += new System.EventHandler(ConditonAdd);
		resources.ApplyResources(this.toolStripMenuItem_ConditonRemove, "toolStripMenuItem_ConditonRemove");
		this.toolStripMenuItem_ConditonRemove.Name = "toolStripMenuItem_ConditonRemove";
		this.toolStripMenuItem_ConditonRemove.Click += new System.EventHandler(toolStripMenuItem_ConditonRemove_Click);
		resources.ApplyResources(this.checkBox_Active, "checkBox_Active");
		this.checkBox_Active.Name = "checkBox_Active";
		this.checkBox_Active.UseVisualStyleBackColor = true;
		this.checkBox_Active.CheckedChanged += new System.EventHandler(checkBox_Active_CheckedChanged);
		resources.ApplyResources(this.checkBox_Run, "checkBox_Run");
		this.checkBox_Run.Name = "checkBox_Run";
		this.checkBox_Run.UseVisualStyleBackColor = true;
		this.checkBox_Run.CheckedChanged += new System.EventHandler(checkBox_Run_CheckedChanged);
		resources.ApplyResources(this.checkBox_AttackValid, "checkBox_AttackValid");
		this.checkBox_AttackValid.Name = "checkBox_AttackValid";
		this.checkBox_AttackValid.UseVisualStyleBackColor = true;
		this.checkBox_AttackValid.CheckedChanged += new System.EventHandler(checkBox_AttackValid_CheckedChanged);
		resources.ApplyResources(this.label_Name, "label_Name");
		this.label_Name.Name = "label_Name";
		resources.ApplyResources(this.textBox_Name, "textBox_Name");
		this.textBox_Name.Name = "textBox_Name";
		this.textBox_Name.Leave += new System.EventHandler(textBox_Name_Leave);
		resources.ApplyResources(this.textBox_Condition, "textBox_Condition");
		this.textBox_Condition.Name = "textBox_Condition";
		this.textBox_Condition.ReadOnly = true;
		resources.ApplyResources(this, "$this");
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.textBox_Condition);
		base.Controls.Add(this.textBox_Name);
		base.Controls.Add(this.label_Name);
		base.Controls.Add(this.checkBox_AttackValid);
		base.Controls.Add(this.checkBox_Run);
		base.Controls.Add(this.checkBox_Active);
		base.Controls.Add(this.propertyGrid_rootConditon);
		base.Controls.Add(this.propertyGrid_Operation);
		base.Controls.Add(this.listBox_listOperation);
		base.Controls.Add(this.listBox_listTriggerPtr);
		base.Controls.Add(this.listBox_listPolicy);
		base.Controls.Add(this.menuStrip_Main);
		base.MainMenuStrip = this.menuStrip_Main;
		base.Name = "MainWindow";
		this.menuStrip_Main.ResumeLayout(false);
		this.menuStrip_Main.PerformLayout();
		this.contextMenuStrip_Policy.ResumeLayout(false);
		this.contextMenuStrip_Trigger.ResumeLayout(false);
		this.contextMenuStrip_Operation.ResumeLayout(false);
		this.contextMenuStrip_rootConditon.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
