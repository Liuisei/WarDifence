using UnityEngine;
[RequireComponent(typeof(ObjectPool))]

public class EnemyGenerator : MonoBehaviour         //エネミーを生成するクラス
{
    [SerializeField] GameObject _spawnPoint;
    [SerializeField,Tooltip("エネミー生成のインターバル")] float _spawnInterval = 3;
    ObjectPool _objectPool;
    float _timer;

    void Awake()
    {
        _objectPool = GameObject.FindAnyObjectByType<ObjectPool>();
    }

    void Update()
    {
        // _timer変数にTime.deltaTimeの数値を足す
        _timer += Time.deltaTime;
        // _timerが_spawnIntervalの数値を超えたらオブジェクトを生成する
        if (_timer > _spawnInterval)
        {
            _timer = 0;
            GameObject objPool = _objectPool.GetObj();
            objPool.transform.position = RandomPos(transform.position);
        }
    }

    Vector3 RandomPos(Vector3 pos)
    {
        pos.x = Random.Range(_spawnPoint.transform.position.x, _spawnPoint.transform.position.x * -1);
        return transform.position = pos;
    }
}