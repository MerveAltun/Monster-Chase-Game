using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereFollow : MonoBehaviour
{

    private Transform player;

    private Vector3 tempPos;
    [SerializeField]
    private float minX, minY;
    [SerializeField]
    private float maxX, maxY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
       Debug.Log("The Selected index:" + GameManager.Instance.charIndex);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;

        tempPos = transform.position;
        tempPos.x = player.position.x;
        if (tempPos.x < minX)
            tempPos.x = minX;
        if (tempPos.x > maxX)
            tempPos.x = maxX;
        

        transform.position = tempPos;
    }


}
