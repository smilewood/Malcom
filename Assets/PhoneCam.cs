using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCam : MonoBehaviour {
    public GameObject camGO;
	// Use this for initialization
	void Start () {
        Debug.Log("available devices: " + WebCamTexture.devices.Length);
	}
	
	// Update is called once per frame
	void Update () {
        var deviceName = WebCamTexture.devices[0].name;

        var webCamTexture = new WebCamTexture(deviceName, 800, 600, 120);

        webCamTexture.Play();

        camGO.GetComponent<Renderer>().material.mainTexture = webCamTexture;
    }
}
