using System;
using Game.Scripts.Concretes.Managers;
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

        public float CurrentFuel => currentFuel / maxFuel;

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += StopFuelParticle;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= StopFuelParticle;
        }

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
                StartFuelParticle();
            }
        }

        public void IncreaseFuel()
        {
            currentFuel += increaseValue;
            
            ClampFuel();

            if (particleSystemFuel.isPlaying)
            {
                StopFuelParticle();
            }
        }

        private void ClampFuel()
        {
            currentFuel = Mathf.Clamp(currentFuel, 0, maxFuel);
        }

        private void StopFuelParticle()
        {
            particleSystemFuel.Stop();
        }

        private void StartFuelParticle()
        {
            particleSystemFuel.Play();
        }
    }
}
