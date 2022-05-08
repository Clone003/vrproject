using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform Destination; 
    public GameObject player;
    //private Collider mCollider;
    // Start is called before the first frame update
    void Start()
    {
        //mCollider = player.GetComponent<Collider>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        //if (other.gameObject == player) {
            Debug.Log("TP");
            player.transform.position = Destination.transform.position;
        //}
    }
}
