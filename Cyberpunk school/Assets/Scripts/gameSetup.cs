using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameSetup : MonoBehaviour
{
    public Image p1;
    public Image p2;  
    public Image p3; 
    public Image p4;

    public TMP_Text t1;
    public TMP_Text t2;
    public TMP_Text t3;
    public TMP_Text t4;

    public Slider hp1;
    public Slider hp2;
    public Slider hp3;
    public Slider hp4;

    public Party p;
    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/" + PlayerPrefs.GetString("Cparty") + ".json";
        StreamReader t = new StreamReader(path);
        string temp = t.ReadToEnd();
        t.Close();
        p = JsonUtility.FromJson<Party>(temp);

        p1.sprite = (Sprite)Resources.Load(p.c1.assetsName, typeof(Sprite));
        p2.sprite = (Sprite)Resources.Load(p.c2.assetsName, typeof(Sprite));
        p3.sprite = (Sprite)Resources.Load(p.c3.assetsName, typeof(Sprite));
        p4.sprite = (Sprite)Resources.Load(p.c4.assetsName, typeof(Sprite));
       
        t1.text = "" + p.c1.role;
        t2.text = "" + p.c2.role;
        t3.text = "" + p.c3.role;
        t4.text = "" + p.c4.role;

        hp1.maxValue = p.c1.hp;
        hp1.value = p.c1.cHp;
        hp2.maxValue = p.c2.hp;
        hp2.value = p.c2.cHp;
        hp3.maxValue = p.c3.hp;
        hp3.value = p.c3.cHp;
        hp4.maxValue = p.c4.hp;
        hp4.value = p.c4.cHp;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

