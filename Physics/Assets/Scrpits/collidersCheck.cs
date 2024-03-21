using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidersCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Me estoy golpeando con " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("No me estoy golpeando con " + other.gameObject.name);
    }
}
