using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float reloadDelay = 1f;
   [SerializeField] AudioClip crashSoundEffect;
    int Crash = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            while (Crash<=1)
            {
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSoundEffect);
                Crash++;
            }
            
           
            GetComponent<PlayerScripts>().DisableControll();
            Invoke("ReloadScene", reloadDelay);
        }


    }


    void ReloadScene()
    {
        SceneManager.LoadScene(0);

    }


}
