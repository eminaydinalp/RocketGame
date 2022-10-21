using DG.Tweening;
using Game.Scripts.Abstracts;
using UnityEngine;

namespace Game.Scripts.Concretes.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] private Vector3 direction;

        [SerializeField] private float factor;
        [SerializeField] private float duration;

        private Vector3 _startPosition;

        private const float FinishFactorValue = 1;
        
        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Start()
        {
            MoveWall();
        }
        

        private void MoveWall()
        {
            DOVirtual.Float(factor, FinishFactorValue, duration, value =>
            {
                Vector3 offset = direction * value;

                transform.position = offset + _startPosition;
            }).SetEase(Ease.InOutSine).SetLoops(-1 , LoopType.Yoyo);
        }
        
    }
}
