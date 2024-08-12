using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class monsterspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {
        while (true)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(1, 5));

            randomIndex = UnityEngine.Random.Range(0, monsterReference.Length);
            randomSide = UnityEngine.Random.Range(0, 3);

            spawnMonster = Instantiate(monsterReference[randomIndex]);
            //left side
            if (randomSide == 0)
            {
                spawnMonster.transform.position = leftPos.position;
                spawnMonster.GetComponent<monsters>().speed = UnityEngine.Random.Range(4, 10);
            }
            else
            {
                //right side
                spawnMonster.transform.position = rightPos.position;
                spawnMonster.GetComponent<monsters>().speed = -UnityEngine.Random.Range(4, 10);
                spawnMonster.transform.localScale = new Vector3(-4.9f, 3.9f, 1);
            }
        }
    }


}
