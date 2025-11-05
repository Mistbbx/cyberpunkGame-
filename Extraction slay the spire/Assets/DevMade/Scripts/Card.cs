using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
[Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;
    public Sprite cardSprite;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Power, int Cost, string CardDesc, Sprite CardSprite)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDesc = CardDesc;
        cardSprite = CardSprite;
        
    }


}
