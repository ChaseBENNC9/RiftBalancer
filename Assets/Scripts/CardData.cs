using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Card Data", menuName = "Cards/Data") ]
public class CardData : ScriptableObject
{
    public string cardName;
    public BuffTypes cardBuff;
    public DebuffTypes cardDebuff;
    public Sprite cardSprite;

    private static Dictionary<BuffTypes, CardEffect> buffMapping = new Dictionary<BuffTypes, CardEffect>
    {
        { BuffTypes.FastWalk, new FastWalk() },
        {BuffTypes.LowGravity, new LowGravity()}
        // { BuffTypes.AutoJump, new A() }
    };

    private static Dictionary<DebuffTypes, CardEffect> debuffMapping = new Dictionary<DebuffTypes, CardEffect>
    {
        // { DebuffTypes.Weakness, new Weakness() },
        // { DebuffTypes.Slow, new Slow() }
        {DebuffTypes.LowSight, new Blindness()}

    };

    public CardEffect GetBuff()
    {
        return buffMapping.TryGetValue(cardBuff, out CardEffect buffEffect) ? buffEffect : null;
    }

    public CardEffect GetDebuff()
    {
        return debuffMapping.TryGetValue(cardDebuff, out CardEffect debuffEffect) ? debuffEffect : null;
    }
}

