using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransforms;
    public Vector3 offsetFromPlayer;

    // Update is called once per frame
    void Update()
    {
        if (playerTransforms == null)
        {
            return;
        }
        transform.position = playerTransforms.position + offsetFromPlayer;
    }
}
