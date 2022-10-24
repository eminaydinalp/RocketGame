using Game.Scripts.Concretes.Controllers;
using Game.Scripts.Concretes.Inputs;
using UnityEngine;

namespace Game.Scripts.Concretes.Movements
{
    public class Mover
    {
        private Rigidbody _rigidbody;
        private float _force;

        public Mover(Rigidbody rigidbody, float force)
        {
            _rigidbody = rigidbody;
            _force = force;
        }
        

        public void Moveup(bool isForceup)
        {
            if (isForceup)
            {
                _rigidbody.AddRelativeForce(Vector3.up * (Time.deltaTime * _force));
            }
        }
        

    }
}
