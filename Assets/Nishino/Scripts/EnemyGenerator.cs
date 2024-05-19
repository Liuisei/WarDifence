using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] Vector2 _xPos; 
    [SerializeField] float _spawnInterval = 3;
    [SerializeField] GameObject _spawnPos;
    ObjectPool _objectPool;
    float _timer;
    
    void Awake()
    {
        _objectPool = GameObject.FindAnyObjectByType<ObjectPool>();
    }
    
    void Update()
    {
        _timer += Time.deltaTime;
        Debug.Log(_timer);
        if (_spawnInterval < _timer)
        {
            _timer = 0;
            GameObject objPool = _objectPool.GetObj(); 
            RandomPos();
            objPool.transform.position = transform.position;
        }
    }

    void  RandomPos()
    {
        int _posx = 0;
        _posx = (int)Random.Range(_xPos.x,_xPos.y);
        transform.position = new Vector3(_posx, transform.position.y,transform.position.z);
        
    }
}
