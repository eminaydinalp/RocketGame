using System;
using UnityEngine;

namespace Game.Scripts.Concretes.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float maxFuel;
        [SerializeField] private float currentFuel;

        [SerializeField] private float decreaseValue;
        [SerializeField] private float increaseValue;

        [SerializeField] private ParticleSystem particleSystemFuel;

        public bool isFuelEmpty => currentFuel < 1;

        private void Start()
        {
            currentFuel = maxFuel;
        }

        public void DecreaseFuel()
        {
            currentFuel -= decreaseValue;

            ClampFuel();

            if (particleSystemFuel.isStopped)
            {
                particleSystemFuel.Play();
            }
        }

        public void IncreaseFuel()
        {
            currentFuel += increaseValue;
            
            ClampFuel();

            if (particleSystemFuel.isPlaying)
            {
                particleSystemFuel.Stop();
            }
        }

        private void ClampFuel()
        {
            currentFuel = Mathf.Clamp(currentFuel, 0, maxFuel);
        }
    }
}
