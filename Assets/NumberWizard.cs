using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	
    void StartGame() {
        ClearConsole();

        max = 1000;
        min = 1;

        Debug.Log("Welcome to Number Wizard YO!!!");
        Debug.Log("Pick a number");
        Debug.Log("Highest number you can pick is: " + max);
        Debug.Log("Lowest number yoy can pick is: " + min);

        FindGuess();

        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Higher");
            min = guess;
            FindGuess();
        } else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Lower");
            max = guess;
            FindGuess();
        } else if(Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Voila");
            StartGame();
        }
    }

    IEnumerator ClearConsole()
    {
        // wait until console visible
        while (!Debug.developerConsoleVisible)
        {
            yield return null;
        }
        yield return null; // this is required to wait for an additional frame, without this clearing doesn't work (at least for me)
        Debug.ClearDeveloperConsole();
    }

    void FindGuess() {
        guess = (min + max) / 2;
        Debug.Log("Tell me if it is higher or lower than: " + guess);
    }
}
