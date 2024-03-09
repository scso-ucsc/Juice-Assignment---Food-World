using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Trigger : MonoBehaviour
{
    //BASED ON "OPENING a DOOR in UNITY on TRIGGER EVENT" - https://www.youtube.com/watch?v=tJiO4cvsHAo
    [SerializeField] private Animator door;
    private bool doorIsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){ //If door is closed and Player enters trigger area, open door
        if(other.CompareTag("Player") && doorIsOpen == false){
            AudioManager.instance.doorOpen(); //Playing door open audio
            door.Play("Door_Open", 0, 0f); //Playing door open animation
            doorIsOpen = true;
        }
    }

    private void OnTriggerExit(Collider other){ //Once Player exits trigger zone, activate Coroutine closeDoor();
        if(other.CompareTag("Player") && doorIsOpen == true){
            StartCoroutine(closeDoor());
        }
    }

    IEnumerator closeDoor(){
        yield return new WaitForSeconds(2f); //Close door after 2 seconds
        AudioManager.instance.doorClose(); //Playing door open audio
        door.Play("Door_Close", 0, 0f);
        doorIsOpen = false;
    }
}
