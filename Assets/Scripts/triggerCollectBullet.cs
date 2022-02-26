using UnityEngine;

public class triggerCollectBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Triggered Collision");
        GameEvents.current.BulletCollected();
    }
}
