using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberwizard : MonoBehaviour
{
        int maxGuess = 1000;
        int minGuess = 1;
        int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number");
        Debug.Log("The lowest number you can choose is: " + minGuess);
        Debug.Log("The highest number you can choose is: " + maxGuess);
        Debug.Log("Is your guess higher or lower than 500?");
        Debug.Log("Push Up = higher, Push Down = lower, Enter = Correct");
        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Dang I'm pretty good at guessing numbers");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}
