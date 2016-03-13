﻿using UnityEngine;

public interface IEnemyController : IViewController {
    void Init(int wave);
}

public class EnemyController : ViewController, IEnemyController {

    [SerializeField] Animator _animator;

    int _wave;

    public void Init(int wave) {
        _wave = wave;
    }

    void Start() {
        _animator.SetInteger("Wave", _wave);
    }
}
