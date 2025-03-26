using System;
using System.Collections;
using UnityEngine.VFX;

public abstract class Buff : CardEffect
{
    protected BuffTypes buff;


    public Buff(float effectMultiplier, float duration, BuffTypes buff)
    {
        this.effectMultiplier = effectMultiplier;
        this.duration = duration;
        this.buff = buff;
        this.applied = false;
    }
}
