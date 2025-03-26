using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameObject activated, disabled;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && CheckpointManager.i.activeCheckpoint != this)
        {
            Activate();
        }     
    }

    public void Deactivate()
    {
        disabled.SetActive(true);
        activated.SetActive(false);
    }

    
    public void Activate()
    {
        disabled.SetActive(false);
        activated.SetActive(true);
        CheckpointManager.i.SetActiveCheckpoint(this);

    }
}
