using System;
using Game.Scripts.Concretes.Inputs;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private DefaultInput _input;

        [SerializeField] private float force;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }

        private void Update()
        {
            Debug.Log(_input.isForceUp);
        }

        private void FixedUpdate()
        {
            if (_input.isForceUp)
            {
                _rigidbody.AddForce(Vector3.up * (Time.deltaTime * force));
            }
        }
    }
}
