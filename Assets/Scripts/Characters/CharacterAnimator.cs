﻿using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimator : MonoBehaviour
{
    static readonly int Walking = Animator.StringToHash("walking");

    Animator _animator;
    bool _walking;
    bool _previousWalking;

    void Awake()
    {
        _animator = GetComponent<Animator>();
        GameStateManager.OnGameOver += StopWalking;
    }

    void Update()
    {
        _walking = InputManager.Input.sqrMagnitude > InputManager.DEAD_ZONE;
        if (_walking != _previousWalking)
        {
            _animator.SetBool(Walking, _walking);
            _previousWalking = _walking;
        }
    }

    void OnDestroy() => GameStateManager.OnGameOver -= StopWalking;

    void StopWalking() => _animator.SetBool(Walking, false);
}
