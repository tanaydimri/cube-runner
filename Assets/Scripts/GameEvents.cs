using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onBulletCollected;
    public void BulletCollected()
    {
        Debug.Log(onBulletCollected);
        if (onBulletCollected == null)
        {
            return;
        }

        onBulletCollected();
    }

    public event Action<int> onBulletsCountUpdated;
    public void BulletsCountUpdated(int bulletCount)
    {
        if (onBulletsCountUpdated == null)
        {
            return;
        }

        onBulletsCountUpdated(bulletCount);
    }

    public event Action onFireABullet;
    public void FireABullet()
    {
        if (onFireABullet == null)
        {
            return;
        }

        onFireABullet();
    }

    public event Action onBulletFired;
    public void BulletFired()
    {
        if (onBulletFired == null)
        {
            return ;
        }

        onBulletFired();
    }
}
