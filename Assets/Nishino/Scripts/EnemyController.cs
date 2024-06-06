using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyController : MonoBehaviour
{
    GameObject _target;
    [SerializeField] float _enemySpeed = -2;
    ObjectPool _objectPool;
    [SerializeField] int _hp;
    public int Hp => _hp;

    public EnemyController(int hp)
    {
        _hp = hp;
    }


    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
        _objectPool = FindAnyObjectByType<ObjectPool>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _enemySpeed * 0.01f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _objectPool.ReleaseObj(gameObject);
        }
    }
}