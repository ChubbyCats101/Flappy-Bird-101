using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnerSC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pipe;
    public float spawnTime = 1;
    private float timer = 0;
    public float heightOfSet = 10;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float minY = transform.position.y - heightOfSet;
            float maxY = transform.position.y + heightOfSet;
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(minY,maxY), 0), transform.rotation);
            timer = 0;
        }
    }
}
