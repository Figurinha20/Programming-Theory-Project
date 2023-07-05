using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public virtual void CreateCube(GameObject cube, Color color, Vector3 position)
    {
        //change color
        cube.GetComponent<MeshRenderer>().material.SetColor("_Color", color);

        Instantiate(cube, position, cube.transform.rotation);

    }
}
