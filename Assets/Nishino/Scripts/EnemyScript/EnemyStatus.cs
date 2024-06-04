using UnityEngine;

[RequireComponent(typeof(EnemyMove))]
public class EnemyStatus : MonoBehaviour //このスクリプトはエネミーにつける
{
    SpriteRenderer _renderer;

    /// <summary>ステータスのデータを受け取る変数</summary>
    EnemyStatusData _enemyData;

    /// <summary>エネミーの画像</summary>
    Sprite _enemySprite;

    /// <summary>エネミーの名前</summary>
    string _enemyName;

    /// <summary>エネミーのID</summary>
    int _enemyID;

    /// <summary>エネミーの攻撃力</summary>
    float _enemyAttackValue;

    /// <summary>エネミーのHP</summary>
    float _enemyHp;

    public string EnemyName
    {
        get => _enemyName;
        set => _enemyName = value;
    }

    public int EnemyId
    {
        get => _enemyID;
        set => _enemyID = value;
    }

    public float EnemyHp
    {
        get => _enemyHp;
        set => _enemyHp = value;
    }

    public float EnemyAttackValue
    {
        get => _enemyAttackValue;
        set => _enemyAttackValue = value;
    }

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>(); //spriteRendererの取得
    }

    void Start()
    {
        _enemyData = EnemyStatusManager.Instance.EnemyStatusData;   //エネミーのステータスのデータを受け取る
        _renderer.sprite = _enemyData.EnemyImage;                   //エネミーの画像を変更する
        gameObject.name = _enemyData.EnemyName;                     //自身の名前を変更する
        _enemyID = _enemyData.EnemyId;                              //エネミーのステータス
        _enemyAttackValue = _enemyData.EnemyAttackPower;            
        _enemyHp = _enemyData.Hp;
    }
}