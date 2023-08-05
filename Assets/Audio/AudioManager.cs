using UnityEngine;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    public static AudioManager instance;
    void Awake()
    {
        //singleton
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        //dont destroy on load
        DontDestroyOnLoad(gameObject);

        //add audio source to each sound
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
        }
    }
    //how to use this
    //using code line
    //FindObjectOfType<AudioManager>().Play("name of the sound");
    public void Play(string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    //stop code
    //FindObjectOfType<AudioManager>().Stop("name of the sound");
    public void Stop(string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }

    //demo
    void Start()
    {
        Play("Theme");
    }
}
