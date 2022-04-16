using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;
    // score epda pe 0 
    int score = 0;
    // 3dd al fors 3 pas 
    int lives = 3;
    bool gameOver = false;
    // hna al no3 text 3la pezhr al score 
    public Text scoreText;

    // hna bea5d al object pa
    private void Awake()
    {

        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // de 3l4an ezwad al score 
    public void IncremenScore()
    {
        // al if de 3l4an law hwa mat ewaf al score ea3ne 5als al fors 
        if (!gameOver)
        {
            score++;
            // hna b7wl mn intger ly string 
            scoreText.text = score.ToString();
        }
        print(score);
    }
    public void DecreaseLife()
    {
        if (lives > 0)
        {// hna m3 kol mara penas wa7d 
            lives--;
            print(lives);
            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
        // de 3l4an twaf al l3ba 5las 
        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }
    public void GameOver()
    {
        // hna bnade 3la fun fe scipt tany 3n tarek instance 
        CandySpawner.instance.StopSpawningCandies();
        // de 3l4an amn3 t3rk al la3p 
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        print("GameOver :(");

    }
    // hna 3l4an law das restart erga3 el3ap tany 
    public void Restart()
    {
        SceneManager.LoadScene("game");
    }
    //hna 3l4an law das 3la menu egblo al menu
    public void BcakToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
