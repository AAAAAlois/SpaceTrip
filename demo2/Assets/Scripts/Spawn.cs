using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject Column;

    public float colddown = 1f;
    float nextSpawn;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GM.isActive)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + colddown;

                Vector3 spawnP = transform.position;
                spawnP.y += Random.Range(-3f, 3f);
                Instantiate(Column, spawnP, transform.rotation);
            }

        }
    }
}
