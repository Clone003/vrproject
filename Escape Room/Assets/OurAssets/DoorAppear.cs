using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAppear : MonoBehaviour
{
    public Completion puzzle;
    public GameObject door;
    private bool complete = false; 
    public ParticleSystem firework;

    // Update is called once per frame
    void Update()
    {
        if (puzzle.maze && puzzle.quiz && puzzle.soccer && !complete) {
            Debug.Log("Completed All puzzles");
            complete = true;
            door.SetActive(true);
            ParticleSystem Firework = Instantiate(firework, door.transform.position, Quaternion.identity) as ParticleSystem;
        }
        else if (!puzzle.maze && !puzzle.quiz && !puzzle.soccer && complete) {
            Debug.Log("Door Reset");
            complete = false;
            door.SetActive(false);
        }
    }
}
