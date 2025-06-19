using UnityEngine;

public class FastWalk : Buff
{
  
    public FastWalk() : base(2f,2f,BuffTypes.FastWalk) {}
     public override void ApplyEffect()
    {
        if ( applied ) return;
        if(GameObject.FindGameObjectWithTag("Player").TryGetComponent(out PlayerController pc))
        {
            pc.currentSpeed *= effectMultiplier;
            applied = true;
        }
    }
    public override void RemoveEffect()
    {
        if (!applied) return;
        if (GameObject.FindGameObjectWithTag("Player").TryGetComponent(out PlayerController pc))
        {
            pc.currentSpeed /= effectMultiplier;
            applied = false;
        }
    }

}