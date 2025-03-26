using System;
using System.Collections;
public abstract class Debuff : CardEffect
{
    protected DebuffTypes debuff;

    public Debuff(float effectMultiplier, float duration, DebuffTypes debuff)
    {
        this.effectMultiplier = effectMultiplier;
        this.duration = duration;
        this.debuff = debuff;
        this.applied = false;
    }
}

