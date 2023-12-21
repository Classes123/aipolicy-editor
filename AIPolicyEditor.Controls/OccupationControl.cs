using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AIPolicyEditor.Controls;

public class OccupationControl : UserControl
{
	public int Occupation;

	private IContainer components;

	private CheckBox checkBox_Occupation_1;

	private CheckBox checkBox_Occupation_2;

	private CheckBox checkBox_Occupation_3;

	private CheckBox checkBox_Occupation_4;

	private CheckBox checkBox_Occupation_5;

	private CheckBox checkBox_Occupation_6;

	private CheckBox checkBox_Occupation_7;

	private CheckBox checkBox_Occupation_8;

	private CheckBox checkBox_Occupation_9;

	private CheckBox checkBox_Occupation_10;

	private CheckBox checkBox_Occupation_11;

	private CheckBox checkBox_Occupation_12;

	private CheckBox checkBox_Occupation_13;

	private CheckBox checkBox_Occupation_14;

	private Button button_OK;

	public OccupationControl(int value)
	{
		InitializeComponent();
		Occupation = value;
		if ((Occupation & 1) > 0)
		{
			checkBox_Occupation_1.Checked = true;
		}
		if ((Occupation & 2) > 0)
		{
			checkBox_Occupation_2.Checked = true;
		}
		if ((Occupation & 4) > 0)
		{
			checkBox_Occupation_3.Checked = true;
		}
		if ((Occupation & 8) > 0)
		{
			checkBox_Occupation_4.Checked = true;
		}
		if ((Occupation & 0x10) > 0)
		{
			checkBox_Occupation_5.Checked = true;
		}
		if ((Occupation & 0x20) > 0)
		{
			checkBox_Occupation_6.Checked = true;
		}
		if ((Occupation & 0x40) > 0)
		{
			checkBox_Occupation_7.Checked = true;
		}
		if ((Occupation & 0x80) > 0)
		{
			checkBox_Occupation_8.Checked = true;
		}
		if ((Occupation & 0x100) > 0)
		{
			checkBox_Occupation_9.Checked = true;
		}
		if ((Occupation & 0x200) > 0)
		{
			checkBox_Occupation_10.Checked = true;
		}
		if ((Occupation & 0x400) > 0)
		{
			checkBox_Occupation_11.Checked = true;
		}
		if ((Occupation & 0x800) > 0)
		{
			checkBox_Occupation_12.Checked = true;
		}
		if ((Occupation & 0x1000) > 0)
		{
			checkBox_Occupation_13.Checked = true;
		}
		if ((Occupation & 0x2000) > 0)
		{
			checkBox_Occupation_14.Checked = true;
		}
	}

	private void button_OK_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (checkBox_Occupation_1.Checked)
		{
			num++;
		}
		if (checkBox_Occupation_2.Checked)
		{
			num += 2;
		}
		if (checkBox_Occupation_3.Checked)
		{
			num += 4;
		}
		if (checkBox_Occupation_4.Checked)
		{
			num += 8;
		}
		if (checkBox_Occupation_5.Checked)
		{
			num += 16;
		}
		if (checkBox_Occupation_6.Checked)
		{
			num += 32;
		}
		if (checkBox_Occupation_7.Checked)
		{
			num += 64;
		}
		if (checkBox_Occupation_8.Checked)
		{
			num += 128;
		}
		if (checkBox_Occupation_9.Checked)
		{
			num += 256;
		}
		if (checkBox_Occupation_10.Checked)
		{
			num += 512;
		}
		if (checkBox_Occupation_11.Checked)
		{
			num += 1024;
		}
		if (checkBox_Occupation_12.Checked)
		{
			num += 2048;
		}
		if (checkBox_Occupation_13.Checked)
		{
			num += 4096;
		}
		if (checkBox_Occupation_14.Checked)
		{
			num += 8192;
		}
		Occupation = num;
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
		this.checkBox_Occupation_1 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_2 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_3 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_4 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_5 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_6 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_7 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_8 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_9 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_10 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_11 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_12 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_13 = new System.Windows.Forms.CheckBox();
		this.checkBox_Occupation_14 = new System.Windows.Forms.CheckBox();
		this.button_OK = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.checkBox_Occupation_1.AutoSize = true;
		this.checkBox_Occupation_1.Location = new System.Drawing.Point(3, 3);
		this.checkBox_Occupation_1.Name = "checkBox_Occupation_1";
		this.checkBox_Occupation_1.Size = new System.Drawing.Size(84, 17);
		this.checkBox_Occupation_1.TabIndex = 0;
		this.checkBox_Occupation_1.Text = "Blademaster";
		this.checkBox_Occupation_1.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_2.AutoSize = true;
		this.checkBox_Occupation_2.Location = new System.Drawing.Point(3, 26);
		this.checkBox_Occupation_2.Name = "checkBox_Occupation_2";
		this.checkBox_Occupation_2.Size = new System.Drawing.Size(59, 17);
		this.checkBox_Occupation_2.TabIndex = 1;
		this.checkBox_Occupation_2.Text = "Wizard";
		this.checkBox_Occupation_2.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_3.AutoSize = true;
		this.checkBox_Occupation_3.Location = new System.Drawing.Point(3, 49);
		this.checkBox_Occupation_3.Name = "checkBox_Occupation_3";
		this.checkBox_Occupation_3.Size = new System.Drawing.Size(63, 17);
		this.checkBox_Occupation_3.TabIndex = 2;
		this.checkBox_Occupation_3.Text = "Psychic";
		this.checkBox_Occupation_3.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_4.AutoSize = true;
		this.checkBox_Occupation_4.Location = new System.Drawing.Point(3, 72);
		this.checkBox_Occupation_4.Name = "checkBox_Occupation_4";
		this.checkBox_Occupation_4.Size = new System.Drawing.Size(86, 17);
		this.checkBox_Occupation_4.TabIndex = 3;
		this.checkBox_Occupation_4.Text = "Venomancer";
		this.checkBox_Occupation_4.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_5.AutoSize = true;
		this.checkBox_Occupation_5.Location = new System.Drawing.Point(3, 95);
		this.checkBox_Occupation_5.Name = "checkBox_Occupation_5";
		this.checkBox_Occupation_5.Size = new System.Drawing.Size(71, 17);
		this.checkBox_Occupation_5.TabIndex = 4;
		this.checkBox_Occupation_5.Text = "Barbarian";
		this.checkBox_Occupation_5.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_6.AutoSize = true;
		this.checkBox_Occupation_6.Location = new System.Drawing.Point(3, 118);
		this.checkBox_Occupation_6.Name = "checkBox_Occupation_6";
		this.checkBox_Occupation_6.Size = new System.Drawing.Size(67, 17);
		this.checkBox_Occupation_6.TabIndex = 5;
		this.checkBox_Occupation_6.Text = "Assassin";
		this.checkBox_Occupation_6.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_7.AutoSize = true;
		this.checkBox_Occupation_7.Location = new System.Drawing.Point(3, 141);
		this.checkBox_Occupation_7.Name = "checkBox_Occupation_7";
		this.checkBox_Occupation_7.Size = new System.Drawing.Size(57, 17);
		this.checkBox_Occupation_7.TabIndex = 6;
		this.checkBox_Occupation_7.Text = "Archer";
		this.checkBox_Occupation_7.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_8.AutoSize = true;
		this.checkBox_Occupation_8.Location = new System.Drawing.Point(3, 164);
		this.checkBox_Occupation_8.Name = "checkBox_Occupation_8";
		this.checkBox_Occupation_8.Size = new System.Drawing.Size(52, 17);
		this.checkBox_Occupation_8.TabIndex = 7;
		this.checkBox_Occupation_8.Text = "Cleric";
		this.checkBox_Occupation_8.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_9.AutoSize = true;
		this.checkBox_Occupation_9.Location = new System.Drawing.Point(3, 187);
		this.checkBox_Occupation_9.Name = "checkBox_Occupation_9";
		this.checkBox_Occupation_9.Size = new System.Drawing.Size(60, 17);
		this.checkBox_Occupation_9.TabIndex = 8;
		this.checkBox_Occupation_9.Text = "Seeker";
		this.checkBox_Occupation_9.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_10.AutoSize = true;
		this.checkBox_Occupation_10.Location = new System.Drawing.Point(3, 210);
		this.checkBox_Occupation_10.Name = "checkBox_Occupation_10";
		this.checkBox_Occupation_10.Size = new System.Drawing.Size(56, 17);
		this.checkBox_Occupation_10.TabIndex = 9;
		this.checkBox_Occupation_10.Text = "Mystic";
		this.checkBox_Occupation_10.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_11.AutoSize = true;
		this.checkBox_Occupation_11.Location = new System.Drawing.Point(3, 233);
		this.checkBox_Occupation_11.Name = "checkBox_Occupation_11";
		this.checkBox_Occupation_11.Size = new System.Drawing.Size(77, 17);
		this.checkBox_Occupation_11.TabIndex = 10;
		this.checkBox_Occupation_11.Text = "Duskblade";
		this.checkBox_Occupation_11.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_12.AutoSize = true;
		this.checkBox_Occupation_12.Location = new System.Drawing.Point(3, 256);
		this.checkBox_Occupation_12.Name = "checkBox_Occupation_12";
		this.checkBox_Occupation_12.Size = new System.Drawing.Size(85, 17);
		this.checkBox_Occupation_12.TabIndex = 11;
		this.checkBox_Occupation_12.Text = "Stormbringer";
		this.checkBox_Occupation_12.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_13.AutoSize = true;
		this.checkBox_Occupation_13.Location = new System.Drawing.Point(3, 279);
		this.checkBox_Occupation_13.Name = "checkBox_Occupation_13";
		this.checkBox_Occupation_13.Size = new System.Drawing.Size(79, 17);
		this.checkBox_Occupation_13.TabIndex = 12;
		this.checkBox_Occupation_13.Text = "Technician";
		this.checkBox_Occupation_13.UseVisualStyleBackColor = true;
		this.checkBox_Occupation_14.AutoSize = true;
		this.checkBox_Occupation_14.Location = new System.Drawing.Point(3, 302);
		this.checkBox_Occupation_14.Name = "checkBox_Occupation_14";
		this.checkBox_Occupation_14.Size = new System.Drawing.Size(81, 17);
		this.checkBox_Occupation_14.TabIndex = 13;
		this.checkBox_Occupation_14.Text = "Edgerunner";
		this.checkBox_Occupation_14.UseVisualStyleBackColor = true;
		this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.button_OK.Location = new System.Drawing.Point(2, 325);
		this.button_OK.Name = "button_OK";
		this.button_OK.Size = new System.Drawing.Size(146, 23);
		this.button_OK.TabIndex = 14;
		this.button_OK.Text = "OK";
		this.button_OK.UseVisualStyleBackColor = true;
		this.button_OK.Click += new System.EventHandler(button_OK_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.button_OK);
		base.Controls.Add(this.checkBox_Occupation_14);
		base.Controls.Add(this.checkBox_Occupation_13);
		base.Controls.Add(this.checkBox_Occupation_12);
		base.Controls.Add(this.checkBox_Occupation_11);
		base.Controls.Add(this.checkBox_Occupation_10);
		base.Controls.Add(this.checkBox_Occupation_9);
		base.Controls.Add(this.checkBox_Occupation_8);
		base.Controls.Add(this.checkBox_Occupation_7);
		base.Controls.Add(this.checkBox_Occupation_6);
		base.Controls.Add(this.checkBox_Occupation_5);
		base.Controls.Add(this.checkBox_Occupation_4);
		base.Controls.Add(this.checkBox_Occupation_3);
		base.Controls.Add(this.checkBox_Occupation_2);
		base.Controls.Add(this.checkBox_Occupation_1);
		base.Name = "OccupationControl";
		base.Size = new System.Drawing.Size(150, 350);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
