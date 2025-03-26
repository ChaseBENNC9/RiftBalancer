using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

[CreateAssetMenu(fileName = "Card Data", menuName = "Cards/Data") ]
public class CardData : ScriptableObject
{
    public string cardName;
    public BuffTypes cardBuff;
    public DebuffTypes cardDebuff;
    public Sprite cardSprite;
}

