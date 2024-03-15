using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showFence : MonoBehaviour
{
    public GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            Instantiate(gameObjects[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
