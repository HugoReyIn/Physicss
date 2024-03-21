using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    private void Movements()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.localPosition += Time.deltaTime * Vector3.left * speed;
        }

        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.localPosition += Time.deltaTime * Vector3.right * speed;
        }

        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.localPosition += Time.deltaTime * Vector3.forward * speed;
        }

        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.localPosition += Time.deltaTime * Vector3.back * speed;
        }
    }
}
