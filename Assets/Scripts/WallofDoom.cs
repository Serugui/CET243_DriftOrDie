using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallofDoom : MonoBehaviour
{
    float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }
}
