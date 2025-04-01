using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower2 : Enermy
{
    // Start is called before the first frame update
    void Start()
    {
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += new Vector3(xDir, yDir, 0) * speed;
        reverseTime += Time.deltaTime;
        if (reverseTime >= reverseInterval)
        {
            reverseTime = 0f;
            xDir = xDir * -1;
            yDir = yDir * -1;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {

            Destroy(other.gameObject);
            health = health - 5;
        }
    }

}
