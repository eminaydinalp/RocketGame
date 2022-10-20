using System;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] private GameObject finishLightsParticle;
        [SerializeField] private GameObject finishFiresParticle;

        [SerializeField] private float contactPointY;
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            
            if(playerController == null) return;

            if (collision.GetContact(0).normal.y == contactPointY)
            {
                finishLightsParticle.SetActive(true);
                finishFiresParticle.SetActive(true);
            }
        }
    }
}
