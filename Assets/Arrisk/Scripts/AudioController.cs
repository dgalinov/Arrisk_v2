using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource asrc;

    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        asrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    public void OnOffVolume()
    {
        asrc.enabled = !asrc.enabled;
    }
}
