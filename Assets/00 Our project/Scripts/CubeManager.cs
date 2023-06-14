using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject[] cubes;
    public Material initialMaterial;
    public Material litUpMaterial;
    
    void Start()
    {
        LightUpRandomCube();

    }


    private void LightUpRandomCube()
    {
        int randomIndex = Random.Range(0, cubes.Length);

        GameObject randomCube = cubes[randomIndex];
        Renderer cubeRenderer = randomCube.GetComponent<Renderer>();
        cubeRenderer.material = litUpMaterial;
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
