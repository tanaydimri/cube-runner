using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public float damage = 10f;
    public float bulletRange = 100f;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onBulletFired += OnFireBullet;
    }

    // Update is called once per frame
    void OnFireBullet()
    {
        RaycastHit hit;
        bool hitResult = Physics.Raycast(MainCamera.transform.position, MainCamera.transform.forward, out hit, bulletRange);

        if (hitResult)
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage, hit);
            }
        }
    }
}
