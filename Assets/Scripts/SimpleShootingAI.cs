using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShootingAI : ParentAI
{
    protected override void Shoot()
    {
        GameObject bul = Instantiate(bullet, FirePoint.position, Quaternion.identity);
        bul.GetComponent<Bullet>().SetDirection(transform.forward);
    }
}
