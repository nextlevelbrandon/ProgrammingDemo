using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    /* [SerializeField] private float moveSpeed;//Controls how fast the object moves. */

    public int moveSpeed; // Controls how fast the player moves.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Input based controls for the player character.

        if(Input.GetKey(KeyCode.RightArrow)) // If the player hits the right arrow key, the object moves right.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;
        }
        if(Input.GetKey(KeyCode.LeftArrow)) // If the player hits the left arrow key, the object moves left.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow)) // If the player hits the up arrow key, the object moves forward.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow)) // If the player hits the down arrow key, the object moves back.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;
        }
    }
}
