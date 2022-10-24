using System;
using Game.Scripts.Concretes.Managers;
using Game.Scripts.Concretes.Utilities;
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
            GameManager.Instance.OnGameOver += StopRocketSound;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= StopFuelParticle;
            GameManager.Instance.OnGameOver -= StopRocketSound;
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
            
            SoundManager.Instance.PlaySound(Consts.RocketClipName);
        }

        public void IncreaseFuel()
        {
            currentFuel += increaseValue;
            
            ClampFuel();

            if (particleSystemFuel.isPlaying)
            {
                StopFuelParticle();
            }
            
            SoundManager.Instance.StopSound(Consts.RocketClipName);
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

        private void StopRocketSound()
        {
            SoundManager.Instance.StopSound(Consts.RocketClipName);
        }
    }
}
