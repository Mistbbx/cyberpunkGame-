using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class OppHp : MonoBehaviour
{
    public static float oppMaxHp;
    public static float oppStaticHp;
    public float oppHp;
    public Image oppHealthImage;
    public TextMeshProUGUI hpText;
    // Start is called before the first frame update
    void Start()
    {
        oppMaxHp = 120;
        oppStaticHp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        oppHp = oppStaticHp;
        oppHealthImage.fillAmount = oppHp / oppMaxHp;

        if (oppHp > oppMaxHp)
        {
            oppHp = oppMaxHp;
        }

        hpText.text = oppHp + " / " + oppMaxHp + " HP";
    }
}
