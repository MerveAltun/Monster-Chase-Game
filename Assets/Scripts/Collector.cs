using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject != null)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}

