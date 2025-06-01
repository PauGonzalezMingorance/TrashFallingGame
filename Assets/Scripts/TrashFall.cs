using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrashFall : MonoBehaviour
{
    public float speed;
    public float destroyDelay = 5f;

    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);    
    }
}
