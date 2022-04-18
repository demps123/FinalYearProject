using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoint : MonoBehaviour
{
    private List<CheckpointSingle> checkpointSingleList;

    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        checkpointSingleList = new List<CheckpointSingle>();

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoints(this);
            checkpointSingleList.Add(checkpointSingle);
        }
    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle)
    {
        Debug.Log(checkpointSingleList.IndexOf(checkpointSingle));
    }
}
