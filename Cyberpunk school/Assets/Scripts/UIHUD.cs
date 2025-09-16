using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHUD : MonoBehaviour
{
    public GameObject pop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("HP").GetComponent<TextMeshProUGUI>().text = ""+charSheet.player.Hp;
        if (Input.GetKeyDown("i"))
            pop.SetActive(true);
    }
}
