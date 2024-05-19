using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    /// <summary></summary>
    [SerializeField] GameObject _instanceObj;
    /// <summary>プールの容量</summary>
    [SerializeField] int _defaultCapacity = 20;  
    /// <summary>最大サイズ</summary>//
    [SerializeField] int _maxSize = 100;
    /// <summary>オブジェクトプール本体</summary>
    ObjectPool<GameObject> _objectPool;

    private void Awake()
    {
        _objectPool = new ObjectPool<GameObject>(
            OnCreatePoolObject,
            OnTakeFromPool,
            OnReturnedToPool,
            OnDestroyPoolObject,
            false,
            _defaultCapacity,
            _maxSize);
    }

    // ObjectPool コンストラクタ 1つ目の引数の関数 
    // プールに空きがないときに新たに生成する処理
    // objectPool.Get()のときに呼ばれる
    GameObject OnCreatePoolObject()
    {
        GameObject obj = Instantiate(_instanceObj);
        return obj;
    }

    // ObjectPool コンストラクタ 2つ目の引数の関数 
    // プールに空きがあったときの処理
    // objectPool.Get()のときに呼ばれる
    void OnTakeFromPool(GameObject target)
    {
        target.SetActive(true);
    }

    // ObjectPool コンストラクタ 3つ目の引数の関数 
    // プールに返却するときの処理
    void OnReturnedToPool(GameObject target)
    {
        target.SetActive(false);
    }

    // ObjectPool コンストラクタ 4つ目の引数の関数 
    // MAXサイズより多くなったときに自動で破棄する
    void OnDestroyPoolObject(GameObject target)
    {
        Destroy(target);
    }
    
    public GameObject GetObj()
    {
        GameObject obj = _objectPool.Get();
        return obj;
    }
    /// <summary>返却用変数</summary>
    /// <param name="obj">引数に自身を入れる</param>
    public void ReleaseObj(GameObject obj)
    {
        _objectPool.Release(obj);
    }
}
