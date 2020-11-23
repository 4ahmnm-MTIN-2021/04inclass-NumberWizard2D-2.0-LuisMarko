using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScore : MonoBehaviour
{
    private Text score;
    private int scoreAmount;

    public GameObject ButtonNext;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 5;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void SubtractScore()
    {
        scoreAmount -= 1;
        if(scoreAmount == 0)
        {
            Debug.Log("Button 5x pressed");
            loadLevel("sceneAdd");
        }
    }

    public void loadLevel(string scene)
    {
            SceneManager.LoadScene(scene);
    }

   
}
