using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpikeTrap : MonoBehaviour
{
    public float distance;
    public float distanceToMove = 5f; // Distance to move in the X-axis
    public void trigger()
    {
       
       {
            // Calculate the new position based on the distance to move
            float newYPosition = transform.position.y + distanceToMove;

            // Update the object's position only along the X-axis
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);

       }
    }
}
