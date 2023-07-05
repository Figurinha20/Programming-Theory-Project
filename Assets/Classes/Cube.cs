using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private bool used = false;

    public virtual void EditCube(GameObject cube, Color color, Vector3 position)
    {
        //change color
        cube.GetComponent<MeshRenderer>().material.SetColor("_Color", color);

        //change position
        cube.transform.position = position;
    }

    // POLYMORPHISM
    public virtual void WackyStuff(int sizeMultiplyer, GameObject cube) //increase size of cube
    {
        if (used)
        {
            cube.transform.localScale /= sizeMultiplyer;
            used = false;
        } 
        else
        {
            cube.transform.localScale *= sizeMultiplyer;
            used = true;
        }
        
    }

    // POLYMORPHISM
    public virtual void WackyStuff(GameObject cube) //change cube to random color
    {
        cube.GetComponent<MeshRenderer>().material.SetColor("_Color", Random.ColorHSV());
    }

    // POLYMORPHISM
    public virtual bool WackyStuff(GameObject cube, bool visible) //make cube dissapear and re-appear
    {
        cube.SetActive(!visible);
        return !visible;
    }

}
