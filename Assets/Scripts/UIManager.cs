using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private GameObject startUI;
    [SerializeField] private GameObject pauseUI;

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
        Time.timeScale = 0f; //Pausing Clock
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            pauseGame();
        }
    }

    private void pauseGame(){
        pauseUI.SetActive(true);
        Time.timeScale = 0f; //Pausing Clock
    }

    public void startGame(){
        startUI.SetActive(false);
        Time.timeScale = 1f; //Reactivating game clock
    }

    public void continueGame(){
        pauseUI.SetActive(false);
        Time.timeScale = 1f; //Reactivating game clock
    }

    public void restartGame(){
        SceneManager.LoadScene("PlayScene");
    }
}
