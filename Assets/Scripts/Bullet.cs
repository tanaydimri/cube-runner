using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.bulletCollected += OnBulletCollected;
    }

    private void OnBulletCollected()
    {
        Debug.Log("Bullet Collected");
    }
}
