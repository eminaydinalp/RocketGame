using System;
using System.Collections;
using Game.Scripts.Abstracts.Unitilies;
using Game.Scripts.Concretes.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.Concretes.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public Action OnGameOver;
        public Action OnSucceed;

        private void Awake()
        {
            SingletonThisGameObject(this);
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
            SoundManager.Instance.StopSound(Consts.MenuMainClipName);
            SoundManager.Instance.PlaySound(Consts.GameMainClipName);
        }
        
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
            SoundManager.Instance.StopSound(Consts.GameMainClipName);
            SoundManager.Instance.PlaySound(Consts.MenuMainClipName);
        }

        public void Exit()
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }
}
