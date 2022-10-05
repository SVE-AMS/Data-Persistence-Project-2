using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public int score;
    public int highScore;
    public string playerName;
    public string playerHighScoreName;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadScore();
    }


    [System.Serializable]
    class SaveData
    {
        public int score;
        public int highScore;
        public string playerName;
        public string playerhighScoreName;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.score = score;
        data.highScore = highScore;
        data.playerName = playerName;
        data.playerhighScoreName = playerHighScoreName;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            score = data.score;
            highScore = data.highScore;
            playerName = data.playerName;
            playerHighScoreName = data.playerhighScoreName;
        }
    }

}
