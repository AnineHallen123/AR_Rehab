using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text timer;

    float currentvalue;
    // Start is called before the first frame update
    void Start()
    {
        currentvalue = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        currentvalue -= 1 * Time.deltaTime;
        timer.text = currentvalue.ToString("0");

    }
}
