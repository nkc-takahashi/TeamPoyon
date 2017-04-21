using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    Ray ray;

	void Start ()
    {

	}

	void Update ()
    {
        //レイをカメラから飛ばす
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin,(Vector2)ray.direction);
    }


}
