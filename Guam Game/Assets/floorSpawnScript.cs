using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorSpawnScript : MonoBehaviour
{
    public GameObject Ground;
    public float spawnRate = 50;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ground, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Debug.Log("Floor Spawned");
            Instantiate(Ground, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
