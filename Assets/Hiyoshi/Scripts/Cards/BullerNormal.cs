using UnityEngine;
public class BullerNormal : Bullet
{
    private float _fixSpeed = 0.01f;
    protected override void BulletBehaviour()
    {
        transform.position += _fixSpeed * Speed * transform.up;
    }

    protected override void StartMethod()
    {
        this.transform.up = EnemyObj.transform.position - this.transform.position;
    }
}
