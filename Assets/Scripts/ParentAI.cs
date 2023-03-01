using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentAI : MonoBehaviour
{
    public float speed = 5f;
    public Transform FirePoint;
    public GameObject bullet;
    public float Cooldown = 0.5f;
    public static int NumberOfEnemies = 0;

    float currentCooldown;
    Rigidbody rb;
    Transform Player;
    // Start is called before the first frame update
    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = GameObject.FindWithTag("Player").transform;
        NumberOfEnemies++;
    }

    // Update is called once per frame
    protected void Update()
    {
        Chase();
        if (currentCooldown <= 0f)
        {
            Shoot();
            currentCooldown = Cooldown;
        }
        currentCooldown -= Time.deltaTime;
    }
    protected virtual void Shoot()
    {

    }
    void Chase()
    {
        Vector3 direction = Player.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        rb.velocity = direction * speed;
        transform.LookAt(Player);
    }
    private void OnDestroy()
    {
        NumberOfEnemies--;
    }
}
