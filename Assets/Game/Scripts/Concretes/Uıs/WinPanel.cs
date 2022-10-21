using Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace Game.Scripts.Concretes.Uıs
{
    public class WinPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

    }
}
