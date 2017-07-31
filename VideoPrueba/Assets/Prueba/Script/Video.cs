using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(AudioSource))]

public class Video : MonoBehaviour
{
    public VideoPlayer vp;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!vp.isPlaying)
            {
                vp.Play();
                sound.Play();
            }
            else
            {
                vp.Pause();
                sound.Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            vp.time -= 1;
            sound.time -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            vp.time += 1;
            sound.time += 1;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            vp.Stop();
            sound.Stop();
        }

    }

    public void Play()
    {
        vp.Play();
        sound.Play(); 
    }

    public void Pause()
    {
        vp.Pause();
        sound.Pause();
    }

    public void Left()
    {
        vp.time -= 1;
        sound.time -= 1;
    }

    public void Right()
    {
        vp.time += 1;
        sound.time += 1;
    }

    public void Stop()
    {
        vp.Stop();
        sound.Stop();
    }
}
