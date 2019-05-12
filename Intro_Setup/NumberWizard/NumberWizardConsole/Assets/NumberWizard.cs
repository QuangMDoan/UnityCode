using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        guess = 500;


        Debug.Log("Welcome to the number wizard game, peace");
        Debug.Log("Enter your number.");
        Debug.Log("pick a number between " + min);
        Debug.Log("and " + max);
        Debug.Log(" Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = lower, Press Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You got it right: " + guess);
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(" Tell me if your number is higher or lower than: " + guess);
    }
}
