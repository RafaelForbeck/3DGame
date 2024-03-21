using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public float interval;
    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            Destroy(gameObject);
        }
    }
}
