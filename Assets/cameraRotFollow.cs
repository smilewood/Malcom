using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotFollow : MonoBehaviour
{
    private Vector3 camRot;
    // Use this for initialization
    void Start()
    {

    }
    public GameObject Cam;

    public bool X, Y, Z;
    // Update is called once per frame
    void Update()
    {
        camRot = Cam.transform.rotation.eulerAngles;
        Vector3 myRot = this.transform.rotation.eulerAngles;
        this.transform.rotation = Quaternion.Euler(
            X ? camRot.x : myRot.x,
            Y ? camRot.y : myRot.y,
            Z ? camRot.z : myRot.z);
    }
}

