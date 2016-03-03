using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
    public GameObject carempty;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = carempty.transform.position + offset/2;
        
	
	}
}
