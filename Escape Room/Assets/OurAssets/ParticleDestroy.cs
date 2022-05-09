using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    ParticleSystem firework;
    // Start is called before the first frame update
    void Start()
    {
        firework = GetComponent<ParticleSystem>();
        Destroy(this.gameObject, firework.main.duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
