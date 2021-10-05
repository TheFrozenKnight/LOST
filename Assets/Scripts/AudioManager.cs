using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static bool Sfx = true;
    public static bool Music = true;
    public static AudioManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public static void ToggleSFX()
    {
        Sfx = !Sfx;
    }
    public static void ToggleMusic()
    {
        Music = !Music;
    }
}
