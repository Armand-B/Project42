using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {
    public GameObject carempty;


    void Update () {
        if (Input.GetButton("r"))
        {
            carempty.transform.position = Vector3.zero;
                }
	
	}
}
