using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    public int guess;
    public Text textGuess;
    

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = Random.Range(1,100);
        textGuess.text = guess.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    void guessNext()
    {
        guess = (min + max) /2;
        textGuess.text = guess.ToString();
        CountScript.CountValue++;
    }

    public void ButtonLow()
    {
        max = guess;
        guessNext();
        Debug.Log("Lower");
    }

    public void ButtonHigher()
    {
        min = guess;
        guessNext();
        Debug.Log("Higher");
    }

    public void ButtonCorrect()
    {
        Debug.Log("correct guess");
        SceneManager.LoadScene("SceneFinish", LoadSceneMode.Single);
    }

 
}
