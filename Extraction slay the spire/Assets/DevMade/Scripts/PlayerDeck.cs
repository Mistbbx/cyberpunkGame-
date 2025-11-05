using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

    public List<Card> container = new List<Card>();
    public int x;
    public static int deckSize;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 12;

        for (int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        if (deckSize < 4)
        {
            cardInDeck1.SetActive(false);
        }
        else cardInDeck1.SetActive(true);

        if (deckSize < 3)
        {
            cardInDeck2.SetActive(false);
        }
        else cardInDeck2.SetActive(true);

        if (deckSize < 2)
        {
            cardInDeck3.SetActive(false);
        }
        else cardInDeck3.SetActive(true);

        if (deckSize < 1)
        {
            cardInDeck4.SetActive(false);
        }
        else cardInDeck4.SetActive(true);

        if (TurnSystem.startTurn)
        {
            StartCoroutine(Draw(1));
            TurnSystem.startTurn = false;
        }
    }

    IEnumerator StartGame()
    {
        for (int i = 0; i <= 4; i++)
        {
            //AudioSource.PlayOneShot(draw, 1f);
            Instantiate(CardToHand, transform.position, transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }
    public void shuffle()
    {
        for (int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    IEnumerator Draw(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Instantiate(CardToHand, transform.position, transform.rotation);
            yield return new WaitForSeconds(1);
        }
    }

}
