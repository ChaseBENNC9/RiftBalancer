using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

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


    public void SelectCard(Image btn)
    {
        foreach (TextMeshProUGUI e in handGui)
        {
            e.gameObject.transform.parent.GetComponent<Image>().color = Color.white;
        }
        btn.color = Color.green;
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
