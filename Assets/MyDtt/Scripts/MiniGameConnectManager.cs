using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DTT.MinigameMemory
{
    public class MiniGameConnectManager : MonoBehaviour
    {
        [SerializeField] private MemoryGameSettings _settings;
        [SerializeField] private MemoryGameManager _memoryGameManager;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private BackToNovelTrigger _backToNovelTrigger;

        private void Start()
        {
            //StartGame();
        }

        public void StartGame()
        {
            Debug.Log("connector start");
            _memoryGameManager.StartGame(_settings);
            _audioSource.Play();
        }

        private void OnEnable() => _memoryGameManager.Finish += StoreResults;

        /// <summary>
        /// Unsubscribes from the game finished event.
        /// </summary>
        private void OnDisable() => _memoryGameManager.Finish -= StoreResults;

        private void StoreResults(MemoryGameResults results)
        {
            Debug.Log($"Amount of turns: {results.amountOfTurns}");
            _audioSource.Stop();
            _backToNovelTrigger.BackToNovel();
        }
    }
}
