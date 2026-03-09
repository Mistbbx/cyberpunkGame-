using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        Debug.Log("Awaken");
        cardList.Add(new Card(0, "none", 0, 0, "none", Resources.Load<Sprite>("")));
        cardList.Add(new Card(1, "human", 3, 1, "this is a human", Resources.Load<Sprite>("image12")));
        cardList.Add(new Card(2, "lightning bolt", 7, 2, "Shoots a lightning bolt", Resources.Load<Sprite>("image11")));
        cardList.Add(new Card(3, "bonk", 24, 7, "BONK!", Resources.Load<Sprite>("image12")));
        cardList.Add(new Card(4, "explosion", 17, 5, "Explodes", Resources.Load<Sprite>("image11")));
    }
}
