using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
    private TrackCheckpoint trackCheckpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Collider>(out Collider collider))
        {
            trackCheckpoint.PlayerThroughCheckpoint(this);
        }
    }
    public void SetTrackCheckpoints(TrackCheckpoint trackCheckpoint)
    {
        this.trackCheckpoint = trackCheckpoint;
    }
}