using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteQuiz : MonoBehaviour
{
    public Completion puzzle;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Completed Quiz");
        puzzle.quiz = true;
    }
}
