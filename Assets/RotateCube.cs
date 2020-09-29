using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {
    public float time;
    public float speed;
    void Start () {
        print ("START");
        time = 0;
    }

    void Update () {
        print ("Update");
        transform.Rotate (Vector3.up * Time.deltaTime*speed, Space.World);
    }
}