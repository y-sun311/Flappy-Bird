using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
   private float leftEdge;
    
    public void Start(){

        // Get the left edge of the screen in world coordinates.
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    
    
    public void Update()
    {
        // Move the pipes to the left by the speed value every second.
        transform.position += Vector3.left * speed * Time.deltaTime;


        if (transform.position.x < leftEdge)
        {
            // Destroy the pipes when they reach the left edge of the screen.
            Destroy(gameObject);
        }
    }
}
