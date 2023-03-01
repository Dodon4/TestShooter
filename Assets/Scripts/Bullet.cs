using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 _direction;
    public float TimeToDestroy = 5f;
    public float Speed = 15f;
    public float Damage = 10;
    public bool isArtillery = false;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isArtillery)
        {
            transform.Translate(_direction * Speed * Time.deltaTime);
        }
 
    }
    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
    private void OnTriggerEnter(Collider other)
    {
        Health hp = other.GetComponent<Health>();
        if (hp)
        {
            hp.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
}
