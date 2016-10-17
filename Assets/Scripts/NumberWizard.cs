using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int min ;
	int max ;
	int guess;

	void Start () {
		StartGame();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("Up arrow was pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("Down arrow was pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
		}
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print ("[Up for higher, down for lower, return for equals]");
		max = max + 1;
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("[Up for higher, down for lower, return for equals]");
	}
}
