using System;
using Game.Scripts.Concretes.Inputs;
using Game.Scripts.Concretes.Managers;
using Game.Scripts.Concretes.Movements;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private DefaultInput _input;
        private Mover _mover;
        private Mover _mover2;
        private Rotator _rotator;
        private Fuel _fuel;

        [SerializeField] private float force;
        [SerializeField] private float turnSpeed;
        [SerializeField] private float turnMaxAngle;

        private bool _isCanForce;
        private bool _isCanMove;

        public bool IsCanMove => _isCanMove;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
            _mover = new Mover(_rigidbody, force);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Start()
        {
            _isCanMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += NotCanMove;
            GameManager.Instance.OnSucceed += NotCanMove;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= NotCanMove;
            GameManager.Instance.OnSucceed -= NotCanMove;
        }

        private void Update()
        {
            if(!_isCanMove) return;
            if (_input.isForceUp && !_fuel.isFuelEmpty)
            {
                _isCanForce = true;
                _fuel.DecreaseFuel();
            }
            else
            {
                _isCanForce = false;
                _fuel.IncreaseFuel();
            }
            
        }

        private void FixedUpdate()
        {
            //_mover.Moveup(_isCanForce);
            _mover.Moveup(_isCanForce);
           _rotator.RotateRightLeft(turnSpeed, _input.leftRightValue, turnMaxAngle);
        }

        private void NotCanMove()
        {
            _isCanForce = false;
            _isCanMove = false;
        }
    }
}
