using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemies;
    public float SpawnTime = 5f;
    public GameObject text;
    bool ReadyToSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator Spawn(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(enemies[Random.Range(0, enemies.Count)], transform.position, Quaternion.identity);
        ReadyToSpawn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(ReadyToSpawn)
        {
            ReadyToSpawn = false;
            StartCoroutine(Spawn(SpawnTime));
        }
        if(ParentAI.NumberOfEnemies == 0)
        {
            text.SetActive(true);
            Destroy(gameObject);
        }
    }
}
