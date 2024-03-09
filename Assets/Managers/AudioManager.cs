using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource doorSource;
    [SerializeField] private AudioSource partyMusicSource;
    [SerializeField] private AudioSource sodaCanSource;
    [SerializeField] private AudioClip doorOpenSound;
    [SerializeField] private AudioClip doorCloseSound;
    [SerializeField] private AudioClip partyMusic;
    [SerializeField] private AudioClip sodaPopSound;

    void Awake(){
        if(instance == null){
            instance = this;
        } else{
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        partyMusicSource.clip = partyMusic;
        partyMusicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doorOpen(){
        doorSource.clip = doorOpenSound;
        doorSource.Play();
    }

    public void doorClose(){
        doorSource.clip = doorCloseSound;
        doorSource.Play();
    }

    public void sodaPop(){
        sodaCanSource.clip = sodaPopSound;
        sodaCanSource.Play();
    }
}
