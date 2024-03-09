using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soda_CanTrigger : MonoBehaviour
{
    [SerializeField] private GameObject sodaCan;
    private ParticleSystem sodaFizzParticles;

    // Start is called before the first frame update
    void Start()
    {
        sodaFizzParticles = sodaCan.GetComponent<ParticleSystem>(); //Accessing particle system of sodaCan
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other){ //If Player enters trigger area, play particles
        if(other.CompareTag("Player")){
            sodaFizzParticles.Play(); //Playing Particle Burst
        }
    }
}
