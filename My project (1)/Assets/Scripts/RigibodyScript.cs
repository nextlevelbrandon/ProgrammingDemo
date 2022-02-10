using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyScript : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rigibody;

    // Start is called before the first frame update
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>(); //The moment the script is active, retrieve the rigibody component of the Gameobject.
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate() //Preferred update method when using anything revolving around physics. Ensures consitent functionality regardless of frame rate
    {
        Debug.Log("Currently detecting" + rigibody);
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
    }
}
