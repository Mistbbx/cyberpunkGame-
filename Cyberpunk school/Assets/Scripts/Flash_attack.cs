using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnController : MonoBehaviour
{
    [Header("Enemy Settings")]
    public List<Card> hand = new List<Card>();     // Cards in enemy hand
    public float playDelay = 1f;                   // Delay before enemy plays a card

    public bool IsEnemyTurn { get; private set; }

    private void OnEnable()
    {
        // turn system (if you wanan change it go ahead)
        TurnManager.OnPlayerTurnEnded += StartEnemyTurn;
    }

    private void OnDisable()
    {
        TurnManager.OnPlayerTurnEnded -= StartEnemyTurn;
    }

    public void StartEnemyTurn()
    {
        if (hand.Count == 0)
        {
            EndEnemyTurn();
            return;
        }

        IsEnemyTurn = true;
        StartCoroutine(EnemyTurnRoutine());
    }

    private IEnumerator EnemyTurnRoutine()
    {
        // Small wait to feel more natural
        yield return new WaitForSeconds(playDelay);

        // it picks a card, rigth now its just a random selection,
        // but you can replace it with a batter ai later.
        Card chosenCard = ChooseCard();
        if (chosenCard != null)
        {
            chosenCard.Play();
            hand.Remove(chosenCard);
        }

        // We can add more actions here if you want enemies with more cards 
        
        yield return new WaitForSeconds(0.5f);
        EndEnemyTurn();
    }

    private Card ChooseCard()
    {
        // pick a random card
        int index = Random.Range(0, hand.Count);
        return hand[index];
    }

    private void EndEnemyTurn()
    {
        IsEnemyTurn = false;
        TurnManager.EndEnemyTurn();
    }
}

