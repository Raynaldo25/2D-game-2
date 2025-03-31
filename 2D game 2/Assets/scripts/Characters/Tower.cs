using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : CharacterBase 
{
    public GameObject bullet;
    public float spawnTimer = 0f;
    public float spawnInterval = 1f;
    public GameObject thisTower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            spawnTimer = 0f;

        }
        DisplayHealth();
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            health = health - 1;
            Destroy(collision.gameObject);

        }
    }
    
}
