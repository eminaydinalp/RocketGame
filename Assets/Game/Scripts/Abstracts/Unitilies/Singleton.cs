using UnityEngine;

namespace Game.Scripts.Abstracts.Unitilies
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        public static T Instance { get; private set; }
        
        protected void SingletonThisGameObject(T entity)
        {
            if (Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
