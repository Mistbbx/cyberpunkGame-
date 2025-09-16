using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JWriter : MonoBehaviour
{

    public Character player;    // Start is called before the first frame update
    void Start()
    {
        player.bio = "Im just a little guy";
        player.Hp = 100;
        player.cHp = player.Hp;
        player.Int = 100;
        player.Str = 90;
        player.Dex = 10;
        player.role = Character.Role.littleGuy;

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
