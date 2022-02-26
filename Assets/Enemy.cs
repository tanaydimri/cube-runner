using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 50f;
    public GameObject explosionEffect;

    public void TakeDamage(float amount, RaycastHit hit)
    {
        health -= amount;
        if (health <= 0)
        {
            Die(hit);
        }
    }

    private void Die(RaycastHit hit)
    {
        GameObject impactGO = Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
        impactGO.SetActive(true);
        Destroy(gameObject);
        Destroy(impactGO, 3f);
    }
}
