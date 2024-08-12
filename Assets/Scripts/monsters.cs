using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsters : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;
    // Start is called before the first frame update
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        
    }
    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);

    }

}
