using UnityEngine;
[CreateAssetMenu(menuName = "EnemyStatus")]
public class EnemyStatusData : ScriptableObject        //エネミーのステータス
{
    /// <summary>エネミーの画像</summary>
    public Sprite EnemyImage;
    /// <summary>エネミーの名前</summary>
    public string EnemyName;
    /// <summary>エネミーのID</summary>
    public int EnemyId;
    /// <summary>エネミーの攻撃力</summary>
    public int EnemyAttackPower;
    /// <summary>エネミーのHP</summary>
    public int Hp;
}
