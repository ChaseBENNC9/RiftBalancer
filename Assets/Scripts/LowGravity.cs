using UnityEditor.Callbacks;
using UnityEngine;

public class LowGravity : Buff
{
    public LowGravity() : base(2f,2f,BuffTypes.FastWalk) {}

    public override void ApplyEffect()
    {
        if (applied) return;
        if (GameObject.FindGameObjectWithTag("Player").TryGetComponent(out PlayerController pc))
        {
            Rigidbody2D rb = pc.gameObject.GetComponent<Rigidbody2D>();
            rb.gravityScale = 1 / effectMultiplier;
            applied = true;
        }
        
    }

    public override void RemoveEffect()
    {
        if (!applied) return;
        if (GameObject.FindGameObjectWithTag("Player").TryGetComponent(out PlayerController pc))
        {
            Rigidbody2D rb = pc.gameObject.GetComponent<Rigidbody2D>();

            rb.gravityScale = 1;
            applied = false;
        }
    }
}