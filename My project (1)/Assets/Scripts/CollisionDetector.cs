using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public float hitCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {

        hitCounter += 1;
        print("I've been hit " + hitCounter + " times.");
    }

    public void OnTriggerEnter(Collider other)
    {
        hitCounter += 1;
        print("Someone entered my radius " + hitCounter + " times.");
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
