using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class UISheet : MonoBehaviour
{
    public TextMeshProUGUI Hp;
    public TextMeshProUGUI Str;
    public TextMeshProUGUI Int;
    public TextMeshProUGUI Dex;
    public TextMeshProUGUI bio;
    public TextMeshProUGUI role;
    public index CharIndex;
    public Image img;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/json/index.json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        CharIndex = JsonUtility.FromJson<index>(temp);


    }

    // Update is called once per frame
    void Update()
    {

        string path = "Assets/json/" + CharIndex.files[i] + ".json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        Character player = JsonUtility.FromJson<Character>(temp);
        charSheet.player = player;

        Hp.text = "Hp : " + charSheet.player.Hp;
        Str.text = "Str : " + charSheet.player.Str;
        Dex.text = "Dex : " + charSheet.player.Dex;
        Int.text = "Int : " + charSheet.player.Int;
        bio.text = "Biography : " + charSheet.player.bio;
        role.text = "Role : " + charSheet.player.role;
        img.sprite = (Sprite)Resources.Load(CharIndex.files[i], typeof(Sprite));
    }

    public void Nextchar()
    {

        if (i < CharIndex.files.Length - 1)
            i++;
        else
            i = 0;


    }
}
