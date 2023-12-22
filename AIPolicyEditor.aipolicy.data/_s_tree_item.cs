using System.ComponentModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class _s_tree_item
{
	public _s_condition mConditon { get; set; } = new _s_condition();


	public _s_tree_item pLeft { get; set; }

	public _s_tree_item pRight { get; set; }

	public override string ToString()
	{
		return string.Format("{0}", "s_tree_item");
	}

	public void Read(BinaryReader br, int listPolicy, int listTriggerPtr)
	{
		mConditon.Read(br, listPolicy, listTriggerPtr);
		while (true)
		{
			switch (br.ReadInt32())
			{
			case 1:
				pLeft = new _s_tree_item();
				pLeft.Read(br, listPolicy, listTriggerPtr);
				break;
			case 2:
				pRight = new _s_tree_item();
				pRight.Read(br, listPolicy, listTriggerPtr);
				break;
			case 3:
			case 4:
				return;
			}
		}
	}

	public void Write(BinaryWriter bw)
	{
		mConditon.Write(bw);
		if (pLeft == null && pRight == null)
		{
			bw.Write(3);
			return;
		}
		if (pLeft != null)
		{
			bw.Write(1);
			pLeft.Write(bw);
		}
		if (pRight != null)
		{
			bw.Write(2);
			pRight.Write(bw);
		}
		bw.Write(4);
	}

	public object Copy()
	{
		_s_tree_item s_tree_item = new _s_tree_item
		{
			mConditon = (mConditon.Copy() as _s_condition)
		};
		if (pLeft != null)
		{
			s_tree_item.pLeft = pLeft.Copy() as _s_tree_item;
		}
		if (pRight != null)
		{
			s_tree_item.pRight = pRight.Copy() as _s_tree_item;
		}
		return s_tree_item;
	}

	public static bool Search(_s_tree_item node, _s_condition._e_condition type)
	{
		if (node.mConditon.iType == type)
		{
			return true;
		}
		if (node.pLeft != null && Search(node.pLeft, type))
		{
			return true;
		}
		if (node.pRight != null && Search(node.pRight, type))
		{
			return true;
		}
		return false;
	}

	public static bool Search(_s_tree_item node, string str)
	{
		if (node.mConditon.pParam != null && node.mConditon.Search(str))
		{
			return true;
		}
		if (node.pLeft != null && Search(node.pLeft, str))
		{
			return true;
		}
		if (node.pRight != null && Search(node.pRight, str))
		{
			return true;
		}
		return false;
	}
}
