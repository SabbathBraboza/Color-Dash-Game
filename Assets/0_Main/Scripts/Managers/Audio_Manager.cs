using UnityEngine;
using System.Collections.Generic;

namespace ColorDash.Managers.AudioManager
{
    [RequireComponent(typeof(AudioSource))]
    public class Audio_Manager : MonoBehaviour
    {
        public static Audio_Manager AudioInstance;

        [Header("A U D I O  C L I P S:")]
        private AudioSource _audioSource;
        public List<AudioClip> Clips;

        private void Awake()
        {
            AudioInstance = this;
            _audioSource = GetComponent<AudioSource>();
        }

        public void PlaySFX(int Index) => _audioSource.PlayOneShot(Clips[Index]);
    }
}
