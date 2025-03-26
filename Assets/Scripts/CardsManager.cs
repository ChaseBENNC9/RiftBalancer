using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.AI;
using NUnit.Framework.Internal;
using Unity.VisualScripting;

public class CardsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<CardData> deck;
    public CardData[] hand;
    [SerializeField] private TextMeshProUGUI[] handGui;
    public TextMeshProUGUI pickText;
    public static CardsManager i;
    [SerializeField] private CardData activeCard;
    public SpriteRenderer playerSpr;
    private void Awake()
    {
        i = this;   
    }
    void Start()
    {
     hand = new CardData[5];   

     AllowSelection(false);
     playerSpr = GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>();
    }

    public void AllowSelection(bool enable = true)
    {

        pickText.gameObject.SetActive(enable);
        foreach (TextMeshProUGUI e in handGui)
        {
            e.gameObject.transform.parent.GetComponent<Button>().enabled = enable;
            if(enable)
                e.gameObject.transform.parent.GetComponent<Image>().color = Color.white;

        }
        GameObject.FindWithTag("Player").GetComponent<PlayerController>().enableMovement = !enable;

    }


    public void SelectCard(Image btn)
    {
        foreach (TextMeshProUGUI e in handGui)
        {
            e.gameObject.transform.parent.GetComponent<Image>().color = Color.white; //reset button colors
        }


        foreach (TextMeshProUGUI e in handGui)
        {
            foreach (CardData card in hand)
            {
                if (card.cardName == e.text &&   e.gameObject.transform.parent.GetComponent<Image>() == btn)
                {
                    activeCard = card;
                    break;
                }
            }
        }
        //temp
        ActivateCard();
        btn.color = Color.green;

        AllowSelection(false);
    }
    public void DealHand()
    {
        AllowSelection(true);
        int deckSize = deck.Count;
        for (int i = 0 ; i < 5 ; i++)
        {

            hand[i] =  DrawCard();
            handGui[i].text = hand[i].cardName;
        }
    }

    private void ActivateCard()
    {

        switch (activeCard.cardName)
        {
    case "Card 1":
        playerSpr.color = Color.red;
        break;

    case "Card 2":
        playerSpr.color = Color.yellow;
        activeCard.GetBuff().ApplyEffect();
        activeCard.GetDebuff().ApplyEffect(); // Fast black square
        break;

    case "Card 3":
        playerSpr.color = Color.blue;
        break;

    case "Card 4":
        playerSpr.color = Color.white;
        break;

    case "Card 5":
        playerSpr.color = Color.gray;
        break;

    case "Card 6":
        playerSpr.color = Color.cyan;
        break;

    default:
        playerSpr.color = Color.green;
        break;
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public void ReplaceCard()
    {
        Discard();
        for (int i = 0 ; i < hand.Length ; i++)
        {
            if (hand[i] == null)
            {
                hand[i] = DrawCard();
                handGui[i].text = hand[i].cardName;
                break;
            }
        }
        AllowSelection();
    }
    private void Discard()
    {

        for (int i = 0 ; i < hand.Length ; i++)
        {
            if (hand[i] == activeCard)
            {
                hand[i] = null;
                handGui[i].text = "Empty";
            }
        }
        for (int i = 0 ; i < deck.Count ; i++)
        {
            if (deck[i] == null)
            {
                deck[i] = activeCard;
                break;
            }
        }
        if(activeCard.GetBuff() != null && activeCard.GetDebuff() != null)
        {

        activeCard.GetBuff().RemoveEffect();
        activeCard.GetDebuff().RemoveEffect();
        }
        activeCard = null;
   




    }

    private CardData DrawCard()
    {
            CardData chosenCard = null;
            int nextCard = Random.Range(0,deck.Count);
            while (deck[nextCard] == null)
            {
                Debug.Log("THE CARD WAS EMPTY");
                nextCard  = Random.Range(0,deck.Count);
            }
            Debug.Log("FOUND A CARD SLOT");   

            chosenCard = deck[nextCard];
            deck[nextCard] = null;
            
            return chosenCard;

    }
}
