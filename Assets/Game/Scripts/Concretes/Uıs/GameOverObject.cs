using System;
using Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace Game.Scripts.Concretes.Uıs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;


        private void Awake()
        {
            if (gameOverPanel.activeSelf)
            {
                gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += OpenGameOverPanel;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= OpenGameOverPanel;
        }

        private void OpenGameOverPanel()
        {
            gameOverPanel.SetActive(true);
        }
    }
}
