using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform[] target;
    public float damping = 6.0f;
    Rigidbody m_Rigidbody;

    private int current;
    // Update is called once per frame
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.freezeRotation = true;
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, target[current].position) > 0.2f)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
        }
    }
}
