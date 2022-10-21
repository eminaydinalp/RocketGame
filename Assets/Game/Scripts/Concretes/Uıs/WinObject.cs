using Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace Game.Scripts.Concretes.Uıs
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;


        private void Awake()
        {
            if (winPanel.activeSelf)
            {
                winPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnSucceed += OpenGameOverPanel;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnSucceed -= OpenGameOverPanel;
        }

        private void OpenGameOverPanel()
        {
            winPanel.SetActive(true);
        }
    }
}
