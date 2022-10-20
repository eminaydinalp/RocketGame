using System;
using UnityEngine;

namespace Game.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        public Action OnGameOver;
        public static GameManager Instance { get; private set; }


        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void TriggerGameOverEvent()
        {
            OnGameOver?.Invoke();
        }
    }
}
