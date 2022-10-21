using Game.Scripts.Concretes.Controllers;
using Game.Scripts.Concretes.Inputs;
using UnityEngine;

namespace Game.Scripts.Concretes.Movements
{
    public class Rotator
    {
        private PlayerController _playerController;

        private float zRotation;
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void RotateRightLeft(float turnSpeed, float leftRightValue)
        {
            if (leftRightValue == 0)
            {
                zRotation = _playerController.transform.rotation.z;
                zRotation = Mathf.Lerp(zRotation,
                    leftRightValue, 0.01f * Time.fixedDeltaTime);
                
                _playerController.transform.rotation = Quaternion.Euler(0, 0, zRotation);
            }

            _playerController.transform.Rotate(Vector3.back * (Time.deltaTime * turnSpeed * leftRightValue));
        }

    }
}
