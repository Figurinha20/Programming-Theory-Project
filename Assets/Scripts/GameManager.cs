using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Cube //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        CreateCube(GameObject.CreatePrimitive(PrimitiveType.Cube), Color.red, new Vector3(0, 0, 0));
        CreateCube(GameObject.CreatePrimitive(PrimitiveType.Cube), Color.green, new Vector3(2, 0, 0));
        CreateCube(GameObject.CreatePrimitive(PrimitiveType.Cube), Color.black, new Vector3(-2, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
