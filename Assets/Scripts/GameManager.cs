using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Cube //INHERITANCE
{
    private GameObject[] cubes = new GameObject[3];
    private bool visible = true;

    // Start is called before the first frame update
    void Start()
    {
        AddCubes(); //ABSTRACTION

        InitCubes(); //ABSTRACTION
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // POLYMORPHISM
        {
            WackyStuff(2, cubes[0]);
        }

        if (Input.GetKeyDown(KeyCode.E)) // POLYMORPHISM
        {
            WackyStuff(cubes[1]);
        }

        if (Input.GetKeyDown(KeyCode.Q)) // POLYMORPHISM
        {
            visible = WackyStuff(cubes[2], visible);
        }
    }

    private void AddCubes()
    {
        for (int i = 0; i < 3; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
    }

    private void InitCubes()
    {
        EditCube(cubes[0], Color.red, new Vector3(0, 0, 0));
        EditCube(cubes[1], Color.green, new Vector3(2, 0, 0));
        EditCube(cubes[2], Color.black, new Vector3(-2, 0, 0));
    }
}
