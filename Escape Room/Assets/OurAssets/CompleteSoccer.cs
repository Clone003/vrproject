using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteSoccer : MonoBehaviour
{
    public Completion puzzle;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Completed Puzzle");
        puzzle.soccer = true;
    }
}
