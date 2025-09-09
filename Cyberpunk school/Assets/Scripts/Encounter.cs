using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encounter : MonoBehaviour
{
    public Mob m;
    public Slider hp;
    public Image img;
    // Start is called before the first frame update
    private void Awake()
    {
        m.currentHp = m.maxHp;
    }

    void Start()
    {
        hp.maxValue = m.maxHp;
        img.sprite = m.s;
    }

    // Update is called once per frame
    void Update()
    {
        hp.value = m.currentHp;
    }

    public void takeDmg(int i)
    {
        m.currentHp -= i;
    }
}
