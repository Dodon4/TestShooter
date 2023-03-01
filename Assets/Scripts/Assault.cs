using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assault : Gun
{
    public float Cooldown = 0.3f;
    float currentCooldown;
    void Start()
    {
        currentCooldown = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && currentCooldown <= 0f)
        {
            Shoot();
            currentCooldown = Cooldown;
        }
        currentCooldown -= Time.deltaTime;
    }
}
