using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using AIPolicyEditor.Controls;

namespace AIPolicyEditor.Editors;

public class enumPolicyTalkTextAppendDataMaskEditor : UITypeEditor
{
	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (context != null && provider != null)
		{
			IWindowsFormsEditorService windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (windowsFormsEditorService != null)
			{
				enumPolicyTalkTextAppendDataMaskControl enumPolicyTalkTextAppendDataMaskControl = new enumPolicyTalkTextAppendDataMaskControl((int)value);
				enumPolicyTalkTextAppendDataMaskControl.Tag = windowsFormsEditorService;
				windowsFormsEditorService.DropDownControl(enumPolicyTalkTextAppendDataMaskControl);
				value = enumPolicyTalkTextAppendDataMaskControl.AppendDataMask;
			}
		}
		return base.EditValue(context, provider, value);
	}

	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		if (context != null)
		{
			return UITypeEditorEditStyle.DropDown;
		}
		return base.GetEditStyle(context);
	}
}
