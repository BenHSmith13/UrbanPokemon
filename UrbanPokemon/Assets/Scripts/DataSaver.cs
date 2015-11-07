using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public static class DataScript{
	public static void Save(PlayerData data){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/TestGameData.dat");
		if(data != null){
			bf.Serialize(file, data);
		}
		file.Close();
	}
	
	public static PlayerData Load(){
		if (File.Exists(Application.persistentDataPath + "/TestGameData.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/TestGameData.dat", FileMode.Open);
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
	public List <SimpleMonster> monsters = new List<SimpleMonster>();
	public int money;
	public string name = "uninitialized";
	public List <SimpleTrophy> trophies = new List<SimpleTrophy>();
	public List <SimpleItem> items = new List<SimpleItem>();
	public List <SimpleNPC> simpleNpcs = new List<SimpleNPC>(); 

}

