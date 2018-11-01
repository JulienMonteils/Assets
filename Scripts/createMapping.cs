using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class createMapping : MonoBehaviour {
 public Transform sol;
public float i;

 
	// Use this for initialization
	void Start () {
		i = 0.1f;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		i += 3.0f;
		Transform route = Instantiate(sol, transform.position,transform.rotation );
		route.localPosition = new Vector3(route.localPosition.x,route.localPosition.y,route.localPosition.z-i);
	
	}
}
