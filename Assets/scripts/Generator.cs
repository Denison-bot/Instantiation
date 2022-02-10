using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        //cube.AddComponent<Material>().material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube;
        GameObject sphere;
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        // init
        cube.transform.position = new Vector3(2, 2, 2);
        sphere.transform.position = new Vector3(4, 4, 4);

        // add rigid body
        cube.AddComponent<Rigidbody>();
        sphere.AddComponent<Rigidbody>();
    }
}
