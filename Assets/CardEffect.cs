using System;
using System.Collections;
public abstract class CardEffect
{
    protected  float duration;
    protected float effectMultiplier;
    protected bool applied;

    public abstract void ApplyEffect();
    public abstract void RemoveEffect();
}
