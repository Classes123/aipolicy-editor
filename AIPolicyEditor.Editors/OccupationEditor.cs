using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using AIPolicyEditor.Controls;

namespace AIPolicyEditor.Editors;

public class OccupationEditor : UITypeEditor
{
	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (context != null && provider != null)
		{
			IWindowsFormsEditorService windowsFormsEditorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
			if (windowsFormsEditorService != null)
			{
				OccupationControl occupationControl = new OccupationControl((int)value);
				occupationControl.Tag = windowsFormsEditorService;
				windowsFormsEditorService.DropDownControl(occupationControl);
				value = occupationControl.Occupation;
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
