using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour
{
    private Player1 _player1;
    private Player2 _player2;

    public GameObject pauseMenu;
    public GameObject endMenu;

    private bool pauseControl;

    public string winnerName;

    public Text winnerText;
    
    void Start()
    {
        _player1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<Player1>();
        _player2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<Player2>();
    }

    void FixedUpdate()
    {
        if ((Input.GetKey (KeyCode.Escape)) && (pauseControl == false)){
            PauseStart();
        }
    }

    public void PauseStart (){   
            _player1.pause = true;
            _player2.pause = true;       
            pauseMenu.SetActive(true);
    }

    public void ContinueGame(){
        _player1.pause = false;
        _player2.pause = false;
        pauseMenu.SetActive(false);

    }

    public void RestartGame(){
        SceneManager.LoadScene(this.gameObject.scene.buildIndex);
    }

    public void Quit() {
        Application.Quit();
    }

    public void GameEnd (){
        endMenu.SetActive(true);
        winnerText.text = winnerName + " venceu a batalha!";
    }

}
