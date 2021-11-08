using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class BestScoreSaveData
{
	public int BestScore;
}

public class ScoreDB : MonoBehaviour
{
	[SerializeField]
	private UnityEvent<int> _scoreLoaded;

	private const string BestScoreSavePath = "/BestScore.dat";
	
	public void SaveBestScore(int score)
	{
		var bf = new BinaryFormatter();
		var file = File.Create(Application.persistentDataPath + "/BestScore.dat");
		
		var data = new BestScoreSaveData { BestScore = score };
		bf.Serialize(file, data);
		
		file.Close();
	}

	public void LoadBestScore()
	{
		var bestScore = 0;
		
		if (File.Exists(Application.persistentDataPath + "/BestScore.dat"))
		{
			var bf = new BinaryFormatter();
			var file = File.Open(Application.persistentDataPath + "/BestScore.dat", FileMode.Open);
			
			var data = (BestScoreSaveData)bf.Deserialize(file);
			
			file.Close();
			bestScore = data.BestScore;
		}
		
		_scoreLoaded?.Invoke(bestScore);
	}
}
