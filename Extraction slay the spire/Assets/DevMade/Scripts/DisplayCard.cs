using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.U2D.Aseprite;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDesc;
    public Sprite cardSprite;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descText;
    public Image cardImage;

    public bool cardBack;
    public static bool staticCardback;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCardsInDeck = PlayerDeck.deckSize;
        displayCard.Add(CardDatabase.cardList[0]);
        
        /*for (int i = 0; i < 5; i++)
        {
            displayCard.Add(CardDatabase.cardList[i]);
            //displayCard[0] = CardDatabase.cardList[id];
            Debug.Log(displayCard[i].id);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        cardDesc = displayCard[0].cardDesc;
        cardSprite = displayCard[0].cardSprite;

        nameText.text = "" + cardName;
        costText.text = "" + cost;
        powerText.text = "" + power;
        descText.text = "" + cardDesc;
        cardImage.sprite = cardSprite;

        Hand = GameObject.Find("Hand");
        if (this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardback = cardBack;

        if (this.tag == "Clone")
        {
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -=1;
            PlayerDeck.deckSize -=1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }
}
