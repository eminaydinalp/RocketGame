using System;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();

            if (playerController != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
