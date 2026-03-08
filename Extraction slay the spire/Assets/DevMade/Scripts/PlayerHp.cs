using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class PlayerHp : MonoBehaviour
{
    public static float maxHp;
    public static float staticHp;
    public float hp;
    public Image HealthImage;
    public TextMeshProUGUI hpText;
    void Start()
    {
        maxHp = 1200;
        staticHp = 1000;
    }
    void Update()
    {
        hp = staticHp;
        HealthImage.fillAmount = hp / maxHp;

        if (hp > maxHp)
        {
            hp = maxHp;
        }

        hpText.text = hp + " / " + maxHp + " HP";
    }
}
