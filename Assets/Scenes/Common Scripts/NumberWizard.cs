using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int maxNumber = 1000;
    [SerializeField] int minMumber = 1;

    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    private void StartGame()
    {
        //Adding 1 so that we can pick the MaxNumber number.
        //maxNumber += 1;
        //guess = (maxNumber + minMumber) / 2;
        //guessText.text = guess.ToString();

        NextGuess();
        //Adding 1 so that we can pick the MaxNumber number.
    }

    public void OnPressHigher()
    {
        minMumber = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxNumber = guess - 1;
        NextGuess();
    }

    private void NextGuess() {
    guess = Random.Range(minMumber, maxNumber + 1);
        guessText.text = guess.ToString();
    }
}
