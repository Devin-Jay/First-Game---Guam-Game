using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorScript : MonoBehaviour
{
    public int moveSpeed = 5;
    public int deadZone = -14;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Floor Destroyed");
            Destroy(gameObject);
        }
    }
}
