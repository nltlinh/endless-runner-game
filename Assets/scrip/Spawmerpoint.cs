using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawmerpoint : MonoBehaviour {

	public GameObject san1;
	void Start () {
		Instantiate(san1,transform.position,Quaternion.identity);
	}
	
	 
		
	
}
