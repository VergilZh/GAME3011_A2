using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLock : MonoBehaviour
{
    public float Speed = 1;
    public AudioSource OpenAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            transform.Rotate(0, 0, Speed);
            if (!OpenAudio.isPlaying)
            {
                OpenAudio.Play();
            }
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            transform.Rotate(0, 0, -Speed);
            if (!OpenAudio.isPlaying)
            {
                OpenAudio.Play();
            }
        }
        else
        {
            OpenAudio.Stop();
        }
    }
}
