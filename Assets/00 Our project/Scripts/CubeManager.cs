using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject[] cubes;
    public Material initialMaterial;
    public Material litUpMaterial;

    int randomIndexOld = 1;
    int randomIndexNew = 0;
    
    void Start()
    {
        LightUpRandomCube();

    }


    public void LightUpRandomCube()
    {
        randomIndexNew = Random.Range(0, cubes.Length);
        /*
        while(randomIndexNew == randomIndexOld){
            randomIndexNew = Random.Range(0, cubes.Length);
            Debug.Log("New Generated " + randomIndexNew + " " + randomIndexOld);
        }
        */

        //------
        if (randomIndexNew == randomIndexOld)
        {
            randomIndexNew = Random.Range(0, cubes.Length);

            if (randomIndexNew == randomIndexOld)
            {
                randomIndexNew = Random.Range(0, cubes.Length);
            }
        }

        //------


        GameObject randomCube = cubes[randomIndexNew];
        Renderer cubeRenderer = randomCube.GetComponent<Renderer>();
        cubeRenderer.material = litUpMaterial;

        randomIndexOld = randomIndexNew;
        Debug.Log("newCube");
            

        
    }

    public void HandleCubeTouch()
    {

        foreach (GameObject cube in cubes)
        {
            Renderer cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material = initialMaterial;
        }

        LightUpRandomCube();
    }

}
