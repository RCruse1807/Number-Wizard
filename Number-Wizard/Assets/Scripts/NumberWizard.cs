using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int minNumber = 1;
    private int maxNumber = 1000;
    private int guess = 500;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Welcome To Number Wizard");
        Debug.Log("Pick A Number");
        Debug.Log("The Lowest Number You Can Pick Is : " + minNumber);
        Debug.Log("The Highest Number You Can Pick Is : " + maxNumber);
        Debug.Log("Tell If Your Number Is Higher Or Lower Than : " + guess);
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Push ENTER = Correct");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP ARROW PRESSED");
            minNumber = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN ARROW PRESSED");
            maxNumber = guess;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER KEY PRESSED");
        }
        
    }
}
