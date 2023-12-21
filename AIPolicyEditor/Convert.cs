using System;
using System.Text;

namespace AIPolicyEditor;

public static class Convert
{
	public static string ByteArray_to_GbkString(this byte[] text)
	{
		return Encoding.GetEncoding("GBK").GetString(text).Split(default(char))[0];
	}

	public static byte[] GbkString_to_ByteArray(this string text, int length)
	{
		Encoding encoding = Encoding.GetEncoding("GBK");
		byte[] array = new byte[length];
		byte[] bytes = encoding.GetBytes(text);
		if (array.Length > bytes.Length)
		{
			Array.Copy(bytes, array, bytes.Length);
		}
		else
		{
			byte[] array2 = array;
			int length2 = array2.Length;
			Array.Copy(bytes, array2, length2);
		}
		return array;
	}

	public static string ByteArray_to_UnicodeString(this byte[] text)
	{
		return Encoding.GetEncoding("Unicode").GetString(text).Split(default(char))[0];
	}

	public static byte[] UnicodeString_to_ByteArray(this string text, int length)
	{
		Encoding encoding = Encoding.GetEncoding("Unicode");
		byte[] array = new byte[length];
		byte[] bytes = encoding.GetBytes(text);
		if (array.Length > bytes.Length)
		{
			Array.Copy(bytes, array, bytes.Length);
		}
		else
		{
			byte[] array2 = array;
			int length2 = array2.Length;
			Array.Copy(bytes, array2, length2);
		}
		return array;
	}
}
