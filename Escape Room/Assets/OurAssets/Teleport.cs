using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform Destination; 
    public GameObject player;

    void OnTriggerEnter(Collider other){
        Debug.Log("TP");
        player.transform.position = Destination.transform.position;
    }
}
