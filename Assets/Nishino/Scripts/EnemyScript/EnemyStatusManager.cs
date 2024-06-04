using UnityEngine;

public class EnemyStatusManager : MonoBehaviour //エネミーのステータスを管理するクラス
{
    public static EnemyStatusManager Instance;

    [SerializeField] EnemyStatusData[] _statusDatas = new EnemyStatusData[10];      //スクリプタブルオブジェクトのデータを管理する
    EnemyStatusData _enemyStatusData;                                               //エネミーのステータスのデータ保存用変数
    public EnemyStatusData EnemyStatusData{ get => _enemyStatusData; set => _enemyStatusData = value; }
    [SerializeField] int _sceneCount;                                               //ステージのカウント     1-1なら0、1-2なら1

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        //今何ステージなのかを受け取り、ステータス変数に代入する
        _enemyStatusData = _statusDatas[_sceneCount];
    }
}