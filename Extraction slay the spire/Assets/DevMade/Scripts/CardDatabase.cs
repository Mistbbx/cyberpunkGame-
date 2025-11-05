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
        cardList.Add(new Card(1, "human", 2, 1, "this is a human", Resources.Load<Sprite>("image12")));
        cardList.Add(new Card(2, "lightning bolt", 1, 2, "Shoots a lightning bolt", Resources.Load<Sprite>("image11")));
        cardList.Add(new Card(3, "bonk", 1, 10, "BONK!", Resources.Load<Sprite>("image12")));
        cardList.Add(new Card(4, "explosion", 4, 5, "Explodes", Resources.Load<Sprite>("image11")));
    }
}
