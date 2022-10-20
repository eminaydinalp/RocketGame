using System;
using Game.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.Concretes.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

            if (playerController != null)
            {
                GameManager.Instance.TriggerGameOverEvent();
            }
        }
    }
}
