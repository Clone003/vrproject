using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteMaze : MonoBehaviour
{
    public Completion puzzle;

    void OnTriggerEnter(Collider other) {
        Debug.Log("Completed Maze");
        puzzle.maze = true;
    }
}
