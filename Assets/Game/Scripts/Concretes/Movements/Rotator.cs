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

        public void RotateRightLeft(float turnSpeed, float leftRightValue, float turnMaxAngle)
        {
            _playerController.transform.rotation = Quaternion.Lerp(_playerController.transform.rotation, 
                Quaternion.Euler(0, 0, -1 * leftRightValue * turnMaxAngle), 
                turnSpeed * Time.deltaTime);
        }

    }
}
