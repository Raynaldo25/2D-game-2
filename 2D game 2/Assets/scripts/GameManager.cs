using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float enemyTimer = 0f;
    public float spawnInterval = 1f;

    public float enemy2Timer = 0f;
    public float spawnInterval2 = 1f;

    public float towerTimer = 0f;
    public float towerInterval = 1f;

    public Vector2 xBounds;
    public Vector2 yBounds;

    public GameObject enemy;
    public GameObject enemy2;
    public GameObject tower;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;
        enemy2Timer += Time.deltaTime;
        towerTimer += Time.deltaTime;
        Vector3 targetPos = new Vector3(Random.Range(xBounds.x, xBounds.y), Random.Range(yBounds.x, yBounds.y), 0);

        if (enemyTimer >= spawnInterval)
        {
            enemyTimer = 0;
            Instantiate(enemy, targetPos, Quaternion.identity);
        }

        if (enemy2Timer >= spawnInterval2)
        {
            enemy2Timer = 0;
            Instantiate(enemy2, targetPos, Quaternion.identity);
        }

        if (towerTimer >= towerInterval)
        {
            towerTimer = 0;
            Instantiate(tower, targetPos, Quaternion.identity);
        }
    }
}
