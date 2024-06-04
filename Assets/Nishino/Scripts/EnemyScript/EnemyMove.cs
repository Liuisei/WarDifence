using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    EnemyStatus _status;
    GameObject _moveTarget;         //移動対象
    [SerializeField] float _enemySpeed = -2;        //移動速度
    ObjectPool _objectPool;
    void Start()
    {
        _moveTarget = GameObject.FindGameObjectWithTag("Player");
        _objectPool = FindAnyObjectByType<ObjectPool>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _moveTarget.transform.position, _enemySpeed * 0.005f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _objectPool.ReleaseObj(gameObject);
        }
    }
}
