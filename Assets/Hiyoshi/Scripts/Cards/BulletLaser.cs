using System;
using UnityEngine;

public class BulletLaser : Bullet
{
    private Vector3 _characterPos;
    protected override void BulletBehaviour()
    {
        EffectController();
    }

    protected override void StartMethod()
    {
        _characterPos = this.transform.position;
        EffectController();
    }

    void EffectController()
    {
        Vector3 _enemyPos = EnemyObj.transform.position;
        this.transform.position = (_enemyPos - _characterPos) / 2 + _characterPos;
        this.transform.up = _enemyPos - this.transform.position;
        
        float _scale_y =
            (float)Math.Pow(
                Math.Pow((double)(_enemyPos.x - _characterPos.x), 2.0d) +
                Math.Pow((double)(_enemyPos.y - _characterPos.y), 2.0d), 0.5d);
        Vector3 tmp = transform.localScale;
        tmp.y = _scale_y;
        transform.localScale = tmp;
    }
}