using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JWriter : MonoBehaviour
{

    public charater player;    // Start is called before the first frame update
    void Start()
    {
        player.bio = "En fix skov ninja fra Fyn";
        player.hp = 100;
        player.sta = 90;
        player.role = charater.Role.Ninja;

        string json = JsonUtility.ToJson(player);
        Debug.Log(json);
        string path = "Assets/ninja.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
