using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escortselector : MonoBehaviour {

    

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(false);		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(true);
        }
	}
}
