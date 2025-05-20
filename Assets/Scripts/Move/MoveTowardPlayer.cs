﻿using UnityEngine;

public class MoveTowardPlayer : MoveBehavior
{
    Transform _playerTransform;
    Vector3 _direction;

    public override void Initialize() => _playerTransform ??= PlayerTransform.Value;

    public override void Move()
    {
        if (_playerTransform == null) return;
        Vector3 playerPos = _playerTransform.position;

        if (Vector3.SqrMagnitude(transform.position - playerPos) < 0.2f) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            playerPos,
            speed * Time.deltaTime);
    }
}
