using Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace Game.Scripts.Concretes.Uıs
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }
    
    }
}
