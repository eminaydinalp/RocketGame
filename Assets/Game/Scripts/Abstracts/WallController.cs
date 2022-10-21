using System;
using Game.Scripts.Concretes.Controllers;
using Game.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.Abstracts
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

            if (playerController != null && playerController.IsCanMove)
            {
                GameManager.Instance.TriggerGameOverEvent();
            }
        }
        
        
    }
}
