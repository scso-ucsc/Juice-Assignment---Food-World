using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco_Light : MonoBehaviour
{
    [SerializeField] private Light lightSource;

    // Start is called before the first frame update
    void Start()
    {
        lightSource = GetComponent<Light>();
        StartCoroutine(changeColour());
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    IEnumerator changeColour(){
        while(true){
            yield return new WaitForSeconds(1f);
            lightSource.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
