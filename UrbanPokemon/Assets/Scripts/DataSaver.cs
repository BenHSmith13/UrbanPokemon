using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using UnityEngine;

public static class DataScript{
	public static void Save(PlayerData data){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/GameData.dat");
		if(data != null){
			bf.Serialize(file, data);
		}
		file.Close();
	}
	
	public static PlayerData Load(){
		if (File.Exists(Application.persistentDataPath + "/GameData.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/GameData.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();
			return data;
		}
		return new PlayerData();
	}
}

[Serializable]
public class PlayerData {
	public float playerXPos;
	public float playerYPos;
	public SimpleMonster[] monsters;
	public int money;
	public string name;
	public SimpleTrophy[] trophies;

}

