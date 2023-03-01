using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public GameObject bullet;
    public Transform FirePoint;
    public Recoil recoil;
    protected void Shoot()
    {
        GameObject bul = Instantiate(bullet, FirePoint.position, Quaternion.identity);
        bul.GetComponent<Bullet>().SetDirection(Camera.main.transform.forward);
        recoil.recoil();    
    }
}
