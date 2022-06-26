using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerEjer3 : MonoBehaviour
{
    public TextMeshPro lifes;
    public TextMeshPro score;

    void Start()
    {
        GlobalScriptsEjer3.currentLife = 5;
        GlobalScriptsEjer3.currentScore = 0;
        
    }

    void Update()
    {
        lifes.text = "Lifes: " + GlobalScriptsEjer3.currentLife;
        score.text = "Score: " + GlobalScriptsEjer3.currentScore;

        if(GlobalScriptsEjer3.currentLife == 0){
            SceneManager.LoadScene("GameOverEjer3");
        }
    }
}
