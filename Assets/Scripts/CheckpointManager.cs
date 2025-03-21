using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CheckpointManager : MonoBehaviour
{
    public Checkpoint activeCheckpoint;
    public static CheckpointManager i;


    private void Awake()
    {
        i = this;
    }

    public void SetActiveCheckpoint(Checkpoint c)
    {
        if (activeCheckpoint != null)
            activeCheckpoint.Deactivate();
        activeCheckpoint = c;
    }
}