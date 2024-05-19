using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    ObjectPool _objectPool;
    Rigidbody2D _rb;
    [SerializeField] float _enemySpeed = -2;

    void Start()
    {
        _objectPool = GameObject.FindAnyObjectByType<ObjectPool>();
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rb.velocity = new Vector2(0, _enemySpeed * -1);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        _objectPool.ReleaseObj(gameObject);
    }
}