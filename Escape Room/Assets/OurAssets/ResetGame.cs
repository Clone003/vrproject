using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public Completion puzzle;

    void OnTriggerEnter(Collider other){
        Debug.Log("Reset Game");
        puzzle.maze = false;
        puzzle.quiz = false;
        puzzle.soccer = false;
    }
}
