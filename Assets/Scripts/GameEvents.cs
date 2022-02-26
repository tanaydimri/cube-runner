using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action bulletCollected;
    public void BulletCollected()
    {
        Debug.Log(bulletCollected);
        if (bulletCollected == null)
        {
            return;
        }

        bulletCollected();
    }

}
