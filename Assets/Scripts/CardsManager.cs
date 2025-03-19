using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class CardsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<CardData> deck;
    public CardData[] hand;
    [SerializeField] private TextMeshProUGUI[] handGui;
    void Start()
    {
     hand = new CardData[5];   
     DealHand();
    }


    private void DealHand()
    {
        int deckSize = deck.Count;
        for (int i = 0 ; i < 5 ; i++)
        {

            
            int nextCard = Random.Range(0,deckSize);
            while (deck[nextCard] == null)
            {
                Debug.Log("THE CARD WAS EMPTY");
                nextCard  = Random.Range(0,deckSize);
            }
            Debug.Log("FOUND A CARD SLOT");    
            hand[i] = deck[nextCard];
            deck[nextCard] = null;
            handGui[i].text = hand[i].cardName;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
