using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOne : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log("clear");
    }
}
