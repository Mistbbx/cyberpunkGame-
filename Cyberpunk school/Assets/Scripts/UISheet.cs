using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class UISheet : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public TextMeshProUGUI sta;
    public TextMeshProUGUI bio;
    public TextMeshProUGUI role;
    public index CharIndex;
    public Image img;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/index.json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        CharIndex = JsonUtility.FromJson<index>(temp);


    }

    // Update is called once per frame
    void Update()
    {

        string path = "Assets/" + CharIndex.files[i] + ".json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        charater player = JsonUtility.FromJson<charater>(temp);
        charSheet.player = player;

        hp.text = "Hp : " + charSheet.player.hp;
        sta.text = "Sta : " + charSheet.player.sta;
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
