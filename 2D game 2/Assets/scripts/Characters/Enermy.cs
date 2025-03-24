using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : CharacterBase
{
    public float speed;
    public float xSpeed;
    public float ySpeed;

    public GameObject thisObject;
    public float xDir = 0f;
    public float yDir = 0f;

    public GameManager manager;

    public float reverseTime;
    public float reverseInterval = 3f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(xSpeed, ySpeed);
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += new Vector3(xDir, yDir, 0) * speed;
        reverseTime += Time.deltaTime;
        if(reverseTime >= reverseInterval)
        {
            reverseTime = 0f;
            xDir = xDir * -1;
            yDir = yDir * -1;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "bomb")
        {
            health = health - 5;
            Destroy(other.gameObject);
        }
    }
}
