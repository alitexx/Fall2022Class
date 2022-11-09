using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource audio;
    public static GameManager instance;
    public float defaultPitch;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            defaultPitch = audio.pitch;
            DontDestroyOnLoad(this.audio);
        }
    }

    public void PauseMusic()
    {
        audio.pitch = 0;
    }
    public void UnPauseMusic()
    {
        audio.pitch = defaultPitch;
    }
}
