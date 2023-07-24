using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    public void OnEnable(){
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }


    public void OnDisable(){
        CancelInvoke(nameof(Spawn));
    }

    public void Spawn(){
        // Instantiate a new GameObject from the prefab.
        GameObject go = Instantiate(prefab, transform.position, Quaternion.identity);

        // Set the height of the new GameObject to a random value between minHeight and maxHeight.
        go.transform.position += Vector3.up * Random.Range(minHeight, maxHeight); 

    }
    
}
