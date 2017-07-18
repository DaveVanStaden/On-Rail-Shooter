using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    [SerializeField]
    private float _Speed;
    private Rigidbody _rigidbody;

    public GameObject impactEffect;

    public float range = 100f;
    public float time = 2f;

    int i = 0;
    int change = 0;
    bool count = false;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * _Speed * 1;//Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);
    }
    private void Update()
    {
        Destroy(gameObject, 1.0f);
        GameObject go = gameObject;
    }
}