using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
   private MeshRenderer meshRenderer;
   private float animationSpeed = 1f;

   private void Awake()
   {
      // Get the MeshRenderer component attached to this GameObject.
      meshRenderer = GetComponent<MeshRenderer>();
   }

   private void Update()
   {
      // Move the background texture to the left by 0.1 units every second.
      meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
   }
}
