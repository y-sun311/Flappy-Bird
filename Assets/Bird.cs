using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    public Sprite[] sprites;
    private int spriteIndex;

    private void Awake()
    {
        // Get the SpriteRenderer component attached to this GameObject.
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        // Set up a repeating call to the AnimateSprite() method.
        // The sprite will change every 0.15 seconds (change the second parameter to modify this).
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void Update()
    {
        // Check for Space key press or touch input to make the bird jump.
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }

        if (Input.touchCount > 0)
        {
            // Check if the touch input began to make the bird jump.
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        // Apply gravity to the bird's movement.
        direction.y += gravity * Time.deltaTime;

        // Move the bird according to the calculated direction.
        transform.position += direction * Time.deltaTime;
    }

   private void AnimateSprite()
{
    
    // Increment the spriteIndex to change to the next sprite.
    spriteIndex++;

    // Check if the spriteIndex exceeds the number of sprites available.
    // If yes, reset the index to start from the first sprite.
    if (spriteIndex >= sprites.Length)
    {
        spriteIndex = 0;
    }

    // Update the SpriteRenderer's sprite to the current sprite based on spriteIndex.
    spriteRenderer.sprite = sprites[spriteIndex];
}


}

