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

        [SerializeField] private float force;
        [SerializeField] private float turnSpeed;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
            _mover = new Mover(_rigidbody, force);
            _rotator = new Rotator(this);
        }

        private void FixedUpdate()
        {
           _mover.Moveup(_input.isForceUp);
           _rotator.RotateRightLeft(turnSpeed, _input.leftRightValue);
        }
    }
}
