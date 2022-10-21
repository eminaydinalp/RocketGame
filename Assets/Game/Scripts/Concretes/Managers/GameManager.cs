using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.Concretes.Managers
{
    public class GameManager : MonoBehaviour
    {
        public Action OnGameOver;
        public Action OnSucceed;
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
        
        public void TriggerSucceedEvent()
        {
            OnSucceed?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }
        
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }

        public void Exit()
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }
}
