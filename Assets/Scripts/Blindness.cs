using UnityEngine;
using UnityEngine.Rendering;

public class Blindness : Debuff
{
    public Blindness() : base(2f,2f,DebuffTypes.LowSight) {}
     public override void ApplyEffect()
    {
        if ( applied ) return;
        if(GameObject.FindGameObjectWithTag("Environment").TryGetComponent(out EnvironmentManager sr))
        {
            sr.SetLightBounds(1,5,1 / effectMultiplier);
            applied = true;
        }
    }
    public override void RemoveEffect()
    {
        if ( !applied ) return;

        if(GameObject.FindGameObjectWithTag("Environment").TryGetComponent(out EnvironmentManager sr))
        {
            sr.SetLightBounds(100,101,1);
            applied = false;
        }
    }

}