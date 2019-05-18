using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int minNumber;
    private int maxNumber;
    private int guess;

    // Start is called before the first frame update
    private void Start()
    {
        StartGame();
        
    }

    private void StartGame()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = 500;

        Debug.Log("Welcome To Number Wizard");
        Debug.Log("Pick A Number");
        Debug.Log("The Lowest Number You Can Pick Is : " + minNumber);
        Debug.Log("The Highest Number You Can Pick Is : " + maxNumber);
        Debug.Log("Tell If Your Number Is Higher Or Lower Than : " + guess);
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Push ENTER = Correct");
        maxNumber += 1;

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I Win");
            StartGame();
        }
        
    }

    private void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is Your Number Higher Or Lower Than: " + guess);
    }
}
