using System;
using Game.Scripts.Concretes.Movements;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace Game.Scripts.Concretes.Uıs
{
    public class FuelSlider : MonoBehaviour
    {
        private Slider _fuelSlider;

        private Fuel _fuel;

        private void Awake()
        {
            _fuelSlider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            _fuelSlider.value = _fuel.CurrentFuel;
        }
    }
}
