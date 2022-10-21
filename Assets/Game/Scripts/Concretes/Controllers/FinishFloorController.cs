using System;
using Game.Scripts.Concretes.Managers;
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
            
            if(playerController == null || !playerController.IsCanMove) return;

            if (collision.GetContact(0).normal.y == contactPointY)
            {
                finishLightsParticle.SetActive(true);
                finishFiresParticle.SetActive(true);
                
                GameManager.Instance.TriggerSucceedEvent();
            }
            else
            {
                GameManager.Instance.TriggerGameOverEvent();
            }
        }
    }
}
