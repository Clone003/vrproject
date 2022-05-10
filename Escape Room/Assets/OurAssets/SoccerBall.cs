using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

    public Transform BallOrigin;
    public GameObject Ball;
    private int score = 0;
    public ParticleSystem firework;
    Rigidbody m_Rigidbody;
    public Transform Destination;
    public GameObject player;
    public Completion puzzle;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            if(score < 2)
            {
                ParticleSystem Firework = Instantiate(firework, Ball.transform.position, Quaternion.identity) as ParticleSystem;
                score++;
                Debug.Log("Goal");
                Debug.Log("Score is: " + score.ToString());
                Ball.transform.position = BallOrigin.transform.position;
                m_Rigidbody.velocity = Vector3.zero;
                m_Rigidbody.angularVelocity = Vector3.zero;
            }
            else
            {
                
                
                ParticleSystem Firework = Instantiate(firework, Ball.transform.position, Quaternion.identity) as ParticleSystem;
                score++;
                Debug.Log("Win");
                Debug.Log("Score is: " + score.ToString());
                Ball.transform.position = BallOrigin.transform.position;
                m_Rigidbody.velocity = Vector3.zero;
                m_Rigidbody.angularVelocity = Vector3.zero;
                Invoke("teleportObject", 2.0f);

                Debug.Log("Completed Soccer");
                puzzle.soccer = true;
            }

        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Out of Bounds");
            Ball.transform.position = BallOrigin.transform.position;
            m_Rigidbody.velocity = Vector3.zero;
            m_Rigidbody.angularVelocity = Vector3.zero;
        }
    }

    void teleportObject()
    {
        player.transform.position = Destination.transform.position;
    }
}
