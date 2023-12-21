using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AIPolicyEditor.Controls;

public class enumPolicyTalkTextAppendDataMaskControl : UserControl
{
	public int AppendDataMask;

	private IContainer components;

	private CheckBox checkBox_enumPTTADMName;

	private CheckBox checkBox_enumPTTADMLocalVar0;

	private CheckBox checkBox_enumPTTADMLocalVar1;

	private CheckBox checkBox_enumPTTADMLocalVar2;

	private CheckBox checkBox_enumPTTADMTalkingName;

	private CheckBox checkBox_enumPTTADM6;

	private Button button_OK;

	public enumPolicyTalkTextAppendDataMaskControl(int value)
	{
		InitializeComponent();
		AppendDataMask = value;
		if ((AppendDataMask & 1) > 0)
		{
			checkBox_enumPTTADMName.Checked = true;
		}
		if ((AppendDataMask & 2) > 0)
		{
			checkBox_enumPTTADMLocalVar0.Checked = true;
		}
		if ((AppendDataMask & 4) > 0)
		{
			checkBox_enumPTTADMLocalVar1.Checked = true;
		}
		if ((AppendDataMask & 8) > 0)
		{
			checkBox_enumPTTADMLocalVar2.Checked = true;
		}
		if ((AppendDataMask & 0x10) > 0)
		{
			checkBox_enumPTTADMTalkingName.Checked = true;
		}
		if ((AppendDataMask & 0x20) > 0)
		{
			checkBox_enumPTTADM6.Checked = true;
		}
	}

	private void button_OK_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (checkBox_enumPTTADMName.Checked)
		{
			num++;
		}
		if (checkBox_enumPTTADMLocalVar0.Checked)
		{
			num += 2;
		}
		if (checkBox_enumPTTADMLocalVar1.Checked)
		{
			num += 4;
		}
		if (checkBox_enumPTTADMLocalVar2.Checked)
		{
			num += 8;
		}
		if (checkBox_enumPTTADMTalkingName.Checked)
		{
			num += 16;
		}
		if (checkBox_enumPTTADM6.Checked)
		{
			num += 32;
		}
		AppendDataMask = num;
		((IWindowsFormsEditorService)base.Tag).CloseDropDown();
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
		this.checkBox_enumPTTADMName = new System.Windows.Forms.CheckBox();
		this.checkBox_enumPTTADMLocalVar0 = new System.Windows.Forms.CheckBox();
		this.checkBox_enumPTTADMLocalVar1 = new System.Windows.Forms.CheckBox();
		this.checkBox_enumPTTADMLocalVar2 = new System.Windows.Forms.CheckBox();
		this.checkBox_enumPTTADMTalkingName = new System.Windows.Forms.CheckBox();
		this.checkBox_enumPTTADM6 = new System.Windows.Forms.CheckBox();
		this.button_OK = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.checkBox_enumPTTADMName.AutoSize = true;
		this.checkBox_enumPTTADMName.Location = new System.Drawing.Point(3, 3);
		this.checkBox_enumPTTADMName.Name = "checkBox_enumPTTADMName";
		this.checkBox_enumPTTADMName.Size = new System.Drawing.Size(125, 17);
		this.checkBox_enumPTTADMName.TabIndex = 0;
		this.checkBox_enumPTTADMName.Text = "enumPTTADMName";
		this.checkBox_enumPTTADMName.UseVisualStyleBackColor = true;
		this.checkBox_enumPTTADMLocalVar0.AutoSize = true;
		this.checkBox_enumPTTADMLocalVar0.Location = new System.Drawing.Point(3, 26);
		this.checkBox_enumPTTADMLocalVar0.Name = "checkBox_enumPTTADMLocalVar0";
		this.checkBox_enumPTTADMLocalVar0.Size = new System.Drawing.Size(145, 17);
		this.checkBox_enumPTTADMLocalVar0.TabIndex = 1;
		this.checkBox_enumPTTADMLocalVar0.Text = "enumPTTADMLocalVar0";
		this.checkBox_enumPTTADMLocalVar0.UseVisualStyleBackColor = true;
		this.checkBox_enumPTTADMLocalVar1.AutoSize = true;
		this.checkBox_enumPTTADMLocalVar1.Location = new System.Drawing.Point(3, 49);
		this.checkBox_enumPTTADMLocalVar1.Name = "checkBox_enumPTTADMLocalVar1";
		this.checkBox_enumPTTADMLocalVar1.Size = new System.Drawing.Size(145, 17);
		this.checkBox_enumPTTADMLocalVar1.TabIndex = 2;
		this.checkBox_enumPTTADMLocalVar1.Text = "enumPTTADMLocalVar1";
		this.checkBox_enumPTTADMLocalVar1.UseVisualStyleBackColor = true;
		this.checkBox_enumPTTADMLocalVar2.AutoSize = true;
		this.checkBox_enumPTTADMLocalVar2.Location = new System.Drawing.Point(3, 72);
		this.checkBox_enumPTTADMLocalVar2.Name = "checkBox_enumPTTADMLocalVar2";
		this.checkBox_enumPTTADMLocalVar2.Size = new System.Drawing.Size(145, 17);
		this.checkBox_enumPTTADMLocalVar2.TabIndex = 3;
		this.checkBox_enumPTTADMLocalVar2.Text = "enumPTTADMLocalVar2";
		this.checkBox_enumPTTADMLocalVar2.UseVisualStyleBackColor = true;
		this.checkBox_enumPTTADMTalkingName.AutoSize = true;
		this.checkBox_enumPTTADMTalkingName.Location = new System.Drawing.Point(3, 95);
		this.checkBox_enumPTTADMTalkingName.Name = "checkBox_enumPTTADMTalkingName";
		this.checkBox_enumPTTADMTalkingName.Size = new System.Drawing.Size(160, 17);
		this.checkBox_enumPTTADMTalkingName.TabIndex = 4;
		this.checkBox_enumPTTADMTalkingName.Text = "enumPTTADMTalkingName";
		this.checkBox_enumPTTADMTalkingName.UseVisualStyleBackColor = true;
		this.checkBox_enumPTTADM6.AutoSize = true;
		this.checkBox_enumPTTADM6.Location = new System.Drawing.Point(3, 118);
		this.checkBox_enumPTTADM6.Name = "checkBox_enumPTTADM6";
		this.checkBox_enumPTTADM6.Size = new System.Drawing.Size(103, 17);
		this.checkBox_enumPTTADM6.TabIndex = 5;
		this.checkBox_enumPTTADM6.Text = "enumPTTADM6";
		this.checkBox_enumPTTADM6.UseVisualStyleBackColor = true;
		this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button_OK.Location = new System.Drawing.Point(2, 141);
		this.button_OK.Name = "button_OK";
		this.button_OK.Size = new System.Drawing.Size(156, 23);
		this.button_OK.TabIndex = 6;
		this.button_OK.Text = "OK";
		this.button_OK.UseVisualStyleBackColor = true;
		this.button_OK.Click += new System.EventHandler(button_OK_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.button_OK);
		base.Controls.Add(this.checkBox_enumPTTADM6);
		base.Controls.Add(this.checkBox_enumPTTADMTalkingName);
		base.Controls.Add(this.checkBox_enumPTTADMLocalVar2);
		base.Controls.Add(this.checkBox_enumPTTADMLocalVar1);
		base.Controls.Add(this.checkBox_enumPTTADMLocalVar0);
		base.Controls.Add(this.checkBox_enumPTTADMName);
		base.Name = "enumPolicyTalkTextAppendDataMaskControl";
		base.Size = new System.Drawing.Size(160, 166);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
