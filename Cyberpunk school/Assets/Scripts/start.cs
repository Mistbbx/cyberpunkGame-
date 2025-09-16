using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class start : MonoBehaviour
{
    private static start _instance;

   public static start getInstance()
    {
        if (_instance == null)
            _instance = new start();

        return _instance;
    }

    public static int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppStart() {
        sceneIndex++;
        SceneManager.LoadScene(1);
    
    }

    public void AppQuit()
    {
        Application.Quit();
    }

    public void LoadGame() {

        string path = "Assets/json/SaveGame.json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        SaveGame loaded;
        loaded = JsonUtility.FromJson<SaveGame>(temp);
        charSheet.player = loaded.player;
        SceneManager.LoadScene(2);


    }


    public void SaveGeme() {

        SaveGame temp = new SaveGame();
        temp.player = charSheet.player;

        string json = JsonUtility.ToJson(temp);
        Debug.Log(json);
        string path = "Assets/json/SaveGame.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();


    }

}
