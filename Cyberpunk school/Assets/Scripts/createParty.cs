using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;
public class createParty : MonoBehaviour
{
    public int index = 1;
    public Party p;
    public string pName;
    public TMP_Text p1;
    public TMP_Text p2;
    public TMP_Text p3;
    public TMP_Text p4;
    public TMP_Text partyName;

    // Start is called before the first frame update
    public void selectMember(int i) {

        switch (i) {
            case 1: p.c1 = UIController.player;
                p1.text = ""+UIController.player.role;
                break;
            case 2: p.c2 = UIController.player;
                p2.text = "" + UIController.player.role;
                break;
            case 3: p.c3 = UIController.player;
                p3.text = "" + UIController.player.role;
                break;
            case 4: p.c4 = UIController.player;
                p4.text = "" + UIController.player.role;
                break;
        }
    
    }

    public void saveParty() {
        pName = partyName.text;
        p.partyName = pName;
        PlayerPrefs.SetString("Cparty", pName);
        string json = JsonUtility.ToJson(p);
        Debug.Log(json);
        string path = "Assets/"+p.partyName+".json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();
        SceneManager.LoadScene(1);
    }
}
