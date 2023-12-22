using System.Collections.ObjectModel;
using System.IO;

namespace AIPolicyEditor.aipolicy.data;

public class CPolicyDataManager
{
	public int uVersion;

	public ObservableCollection<CPolicyData> listPolicy = new ObservableCollection<CPolicyData>();

	public void Read(string path)
	{
		FileStream fileStream = File.OpenRead(path);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		uVersion = binaryReader.ReadInt32();
		int num = binaryReader.ReadInt32();
		listPolicy = new ObservableCollection<CPolicyData>();

		for (int i = 0; i < num; i++)
		{
			CPolicyData cPolicyData = new CPolicyData();
			cPolicyData.Read(binaryReader, i);
			listPolicy.Add(cPolicyData);
		}

		fileStream.Close();
		binaryReader.Close();
	}

	public void Write(string path)
	{
		BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write));
		binaryWriter.Write(uVersion);
		binaryWriter.Write(listPolicy.Count);
		for (int i = 0; i < listPolicy.Count; i++)
		{
			listPolicy[i].Write(binaryWriter);
		}
		binaryWriter.Close();
	}
}
