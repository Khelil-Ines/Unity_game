using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Platformer
{
    public class GameManager : MonoBehaviour
    {
        public int coinsCounter = 0;
        public int levelcoin = 20;
        public int id = 1;
        public GameObject playerGameObject;
        private PlayerController player;
        //public GameObject deathPlayerPrefab;
        public GameObject winUI;
        public GameObject LostUI;
        public Text coinText;
        public Text CoinsWinText;
        public Slider slider;
        public Clock clock;
        private Menu menu = null;
        private AudioSource audioSource;
        public AudioClip audioClip;
        public AudioClip audioClipbase;
        bool isMusicPlaying = true;

        void Start()
        {
            player = GameObject.Find("Player").GetComponent<PlayerController>();
            if (GameObject.FindWithTag("Menu") != null)
            {

                menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<Menu>();
                audioSource = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
                audioSource.volume = 0.5f;
                if (audioSource.clip == audioClip) { 
                audioSource.clip = audioClipbase;
                audioSource.Play();
                }
                Debug.Log("hello");
            }
        }

        void Update()
        {
            coinText.text = coinsCounter.ToString();
            if(coinsCounter >= levelcoin)
            {
                if (audioSource != null && isMusicPlaying)
                {
                    isMusicPlaying = false;
                    audioSource.clip = audioClip;
                    audioSource.Play();
                }
                if (menu != null) {
                    
                    if (id == 1)
                menu.isScene2Active = true;
                if(id == 2)
                menu.isScene3Active = true;
                }
                CoinsWinText.text = coinsCounter.ToString();
                winUI.SetActive(true);
                
                Time.timeScale = 0f;
            }
            if (clock.done || slider.value == 0)
            {
                player.DeathTime();
                player.deathState = true;
            }
            if(player.deathState == true )
            {
                if (audioSource != null)
                {
                    audioSource.clip = audioClip;
                    audioSource.Play();
                }
                Invoke("ReloadLevel", 1);
            }
        }

        private void ReloadLevel()
        {


            playerGameObject.SetActive(false);
            //GameObject deathPlayer = (GameObject)Instantiate(deathPlayerPrefab, playerGameObject.transform.position, playerGameObject.transform.rotation);
            //deathPlayer.transform.localScale = new Vector3(playerGameObject.transform.localScale.x, playerGameObject.transform.localScale.y, playerGameObject.transform.localScale.z);
            player.deathState = false;
            LostUI.SetActive(true);
            
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.LoadLevel(Application.loadedLevel);
        }

        public void SetHealth(int health)
        {
            slider.value = health;
        }
    }
}
