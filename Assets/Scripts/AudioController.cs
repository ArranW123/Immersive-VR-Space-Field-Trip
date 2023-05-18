using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    AudioSource audiosrc;
    public AudioClip mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        //Declaring Audio Object
        audiosrc = gameObject.AddComponent<AudioSource>();

        //Assign audio clip to Audio Object
        audiosrc.clip = mainMenu;
    
    }

    //---- For Mini Game Planets ----//
    public void playMainMenu(){
        audiosrc.Play();
    }

    public void stopMainMenu(){
        audiosrc.Stop();
    }
}
