using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI guessText;
    [SerializeField] private int minNumber;
    [SerializeField] private int maxNumber;
    private int guess;

    // Start is called before the first frame update
    private void Start()
    {
        StartGame();
        
    }

    private void StartGame()
    {
        NextGuess();
        

    }
    public void OnPressHigherGuess()
    {
        minNumber = guess + 1;
        NextGuess();
    }

    public void OnPressLowerGuess()
    {
        maxNumber = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = Random.Range(minNumber, maxNumber + 1);
        guessText.text = guess.ToString();

    }

}
