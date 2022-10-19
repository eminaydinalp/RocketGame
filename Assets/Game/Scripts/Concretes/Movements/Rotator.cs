using Game.Scripts.Concretes.Controllers;
using Game.Scripts.Concretes.Inputs;
using UnityEngine;

namespace Game.Scripts.Concretes.Movements
{
    public class Rotator
    {
        private Rigidbody _rigidbody;
        private PlayerController _playerController;
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = _playerController.GetComponent<Rigidbody>();
        }

        public void RotateRightLeft(float turnSpeed, float leftRightValue)
        {
            /*if (_input.leftRightValue == 0)
            {
                _rigidbody.freezeRotation = true;
            }
            else
            {
                _rigidbody.freezeRotation = false;
            }*/
            _playerController.transform.Rotate(Vector3.back * (Time.deltaTime * turnSpeed * leftRightValue));
        }

    }
}
