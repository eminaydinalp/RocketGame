using System;
using Game.Scripts.Abstracts.Unitilies;
using UnityEngine;

namespace Game.Scripts.Concretes.Managers
{
    public class SoundManager : Singleton<SoundManager>
    {
        private AudioSource[] audioSources;
        
        
        private void Awake()
        {
            SingletonThisGameObject(this);

            audioSources = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!audioSources[index].isPlaying)
            {
                audioSources[index].Play();
            }
        }
        
        public void StopSound(int index)
        {
            if (audioSources[index].isPlaying)
            {
                audioSources[index].Stop();
            }
        }
    }
}
