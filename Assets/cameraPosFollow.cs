using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPosFollow : MonoBehaviour
{
    private Vector3 camPos;
    // Use this for initialization
    void Start()
    {

    }
    public GameObject Cam;

    public bool X, Y, Z;
    // Update is called once per frame
    void Update()
    {
        camPos = Cam.transform.position;
        this.transform.position = new Vector3(
            X ? camPos.x : this.transform.position.x,
            Y ? camPos.y : this.transform.position.y,
            Z ? camPos.z : this.transform.position.z);
    }
}
