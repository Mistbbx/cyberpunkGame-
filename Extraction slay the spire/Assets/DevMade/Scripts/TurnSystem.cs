using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnSystem : MonoBehaviour
{
    public static bool isYourTurn;
    public static int turnNr;
    public TextMeshProUGUI turnText;

    public int maxMana;
    public int currentMana;
    public TextMeshProUGUI manaText;

    public static bool startTurn;


    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;
        turnNr = 1;
        
        maxMana = turnNr;
        currentMana = maxMana;

        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isYourTurn)
        {
            turnText.text = "Your Turn " + turnNr;
        }
        else
        {
            turnText.text = "Opponent Turn " + turnNr;
        }

        manaText.text = currentMana + "/" + maxMana;
    }

    public void NextTurn()
    {
        if (isYourTurn)
        {
            isYourTurn = false;
        }
        else
        {
            isYourTurn = true;
            turnNr++;
            maxMana++;
            currentMana = maxMana;
            startTurn = true;
        }
    }
}
