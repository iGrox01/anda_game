using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 5f;

    private void Update()
    {
        Vector2 direction = (playerTransform.position - transform.position).normalized;
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }
}
