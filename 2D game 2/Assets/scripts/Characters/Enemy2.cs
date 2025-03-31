using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enermy
{
    public GameObject targetTower;

    // Start is called before the first frame update
    void Start()
    {
        targetTower = GameObject.FindWithTag("tower");
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += VectorToTower() * speed;

        if (health <= 0)
        {
            
            Destroy(gameObject);
        }

    }
    Vector3 VectorToTower()
    {
        Vector3 targetDirection;
        targetDirection = targetTower.transform.position - transform.position;
        targetDirection = targetDirection.normalized;
        return targetDirection;

    }

}
