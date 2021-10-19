using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{

    float currentTime = 0;

    private void Update()
    {
        currentTime += Time.deltaTime;
    }
}
