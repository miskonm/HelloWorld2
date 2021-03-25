using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public Text label;
    public int min = 5;
    public int max = 750;
    
    private int guess;
    
    private void Start()
    {
        print("Загадай число от " + min + " до " + max);
        UpdateGuess();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("Конец игры.");
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        label.text = "Ты загадал " + guess + "?";
        print("Ты загадал " + guess + "?");
    }
}
