using Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace Game.Scripts.Concretes.Uıs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void NoClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}
