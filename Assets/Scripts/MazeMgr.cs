using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MazeMgr : MonoBehaviour
{
    //public int lives; // do this later
    public bool gameOver;
    public bool gameWon;
    public bool stopMovement;
    //public int score;
    public Text winText;
    public Text loseText;
    public Text options;

    void Start()
    {
        gameOver = false;
        gameWon = false;
        stopMovement = false;
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (gameOver) {
            stopMovement = true;
            LoseGame();
        }
        else if (gameWon) {
            stopMovement = true;
            WinGame();
        }
        
        if (Input.GetKeyDown("q")) {
            GameQuit();
        }
        else if (Input.GetKeyDown("r")) {
            Reload();
        }
    }

    public void Reload(){
        // print to screen
        //StartCoroutine(Reload());
        //yield return new WaitForSeconds(2);
        SceneManager.LoadScene("atromaze");
    }

    public void GameQuit() {
        // print to screen
        //StartCoroutine(GameQuit());
        //yield return new WaitForSeconds(2);
        // so it doesn't look like it just crashed
        Application.Quit();
    }

    public void WinGame() {
        winText.gameObject.SetActive(true);
        loseText.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
        // astronaut and spaceship sail away or something
    }

    public void LoseGame() {
        gameOver = false;
        loseText.gameObject.SetActive(true);
        winText.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
        // blow everything up, fireball, black hole, whatever
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("wall")) {
            Rigidbody rb = b.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.useGravity = true;
            Vector3 dir = new Vector3(Random.Range(2.0f, 16.0f), 
                            Random.Range(2.0f, 16.0f), Random.Range(2.0f, 16.0f));
            rb.velocity = dir;
        }
    }
}
