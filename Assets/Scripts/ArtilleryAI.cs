using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtilleryAI : ParentAI
{
    public float force = 32f;
    // Start is called before the first frame update
    protected override void Shoot()
    {
        Rigidbody bul = Instantiate(bullet, FirePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
        bul.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
