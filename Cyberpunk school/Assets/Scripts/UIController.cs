using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;


public class UIController : MonoBehaviour
{
    public Character player;
    public TextMeshProUGUI bio;
    public TextMeshProUGUI Hp;
    public TextMeshProUGUI Str;
    public TextMeshProUGUI Int;
    public TextMeshProUGUI Dex;
    public TextMeshProUGUI Role;
    public files f;
    public int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string path = "Assets/index.json";
        StreamReader t = new StreamReader(path);
        string temp = t.ReadToEnd();
        t.Close();
        f = JsonUtility.FromJson<files>(temp);
        Debug.Log(f.filnavn[0]);

        string path2 = "Assets/" + f.filnavn[i] + ".json";
        StreamReader tt = new StreamReader(path2);
        string temp2 = tt.ReadToEnd();
        tt.Close();
        player = JsonUtility.FromJson<Character>(temp2);
    }

    // Update is called once per frame
    void Update()
    {
        bio.text = "BIO : " + player.bio;
        Hp.text = "HP : " + player.Hp;
        Str.text = "STR : " + player.Str;
        Int.text = "INT : " + player.Int;
        Dex.text = "DEX : " + player.Dex;
        Role.text = "Role : " + player.role;
    }

    public void NextChar()
    {
        if (i < f.filnavn.Length - 1)
        {
            i++;
        }
        else
        {
            i = 0;
        }
        string path2 = "Assets/" + f.filnavn[i] + ".json";
        StreamReader tt = new StreamReader(path2);
        string temp2 = tt.ReadToEnd();
        tt.Close();
        player = JsonUtility.FromJson<Character>(temp2);
    }
    
    public void PrevChar()
    {
        if (i > 0) {
            i--;
        } else {
            i = f.filnavn.Length - 1;
        }
        string path2 = "Assets/" + f.filnavn[i] + ".json";
        StreamReader tt = new StreamReader(path2);
        string temp2 = tt.ReadToEnd();
        tt.Close();
        player = JsonUtility.FromJson<Character>(temp2);
    }
}
