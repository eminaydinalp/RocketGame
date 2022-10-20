using System;
using Game.Scripts.Concretes.Inputs;
using Game.Scripts.Concretes.Movements;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private DefaultInput _input;
        private Mover _mover;
        private Rotator _rotator;
        private Fuel _fuel;

        [SerializeField] private float force;
        [SerializeField] private float turnSpeed;

        private bool _isCanForce;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
            _mover = new Mover(_rigidbody, force);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Update()
        {
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
           _mover.Moveup(_isCanForce);
           _rotator.RotateRightLeft(turnSpeed, _input.leftRightValue);
        }
    }
}
