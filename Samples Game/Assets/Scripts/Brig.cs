using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Brig : MonoBehaviour
{

    public GameObject[] objs = new GameObject[3];

    public Transform target;

    public Light light;

    public Transform[] transform = new Transform[3];
    public float speed = 5f, rotatespeed = 30f;

    private void Start()
    {
        //obj.SetActive(false);
        //obj.GetComponent<Transform>().position = new Vector3(3, 7, 6);
       // target.position = new Vector3(10, 5, 4);
       // light.intensity = 0.5f;

        //for (int i = 0; i < objs.Length; i++)
            //objs[i].SetActive(false);

    }

    private void Update()
    {
        for (int i = 0; i < transform.Length; i++)
        {
            if (transform[i] == null)
                continue;

            transform[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            transform[i].Rotate(new Vector3(-1, 0, 0) * rotatespeed * Time.deltaTime);

            float posX = transform[i].position.x;

            if (posX < -10 && transform[i].gameObject.name == "Cube")
            {
                Destroy(transform[i].gameObject);
            }
        }

    }

}
