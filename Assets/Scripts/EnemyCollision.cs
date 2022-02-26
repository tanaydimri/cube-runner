using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private GameObject _fracturedPlayer;
    [SerializeField] private GameObject _particleEffect;
    [SerializeField] private GameObject _loserUi;
    [SerializeField] private float _breakForce = 2f;
    [SerializeField] private float _collisionMultiplier = 100f;
    
    private bool _isShattered = false;

     void OnCollisionEnter(Collision collisionInfo)
    {
        if (_isShattered)
        {
            return;
        }

        if (collisionInfo.collider.tag != "Enemy")
        {
            return;
        }

        FindObjectOfType<GameManager>().EndGame();

        if (collisionInfo.relativeVelocity.magnitude >= _breakForce)
        {
            _isShattered = true;
            var fracturedReplacement = Instantiate(_fracturedPlayer, transform.position, transform.rotation);
            fracturedReplacement.SetActive(true);

            var rbs = fracturedReplacement.GetComponentsInChildren<Rigidbody>();
            foreach (var rb in rbs) 
            {
                rb.AddExplosionForce(collisionInfo.relativeVelocity.magnitude * _collisionMultiplier, collisionInfo.contacts[0].point, 2);
            }

            var particleEffect = Instantiate(_particleEffect, transform.position, Quaternion.identity);
            particleEffect.SetActive(true);
            _loserUi.SetActive(true);

            Destroy(gameObject);
        }
    }
}
