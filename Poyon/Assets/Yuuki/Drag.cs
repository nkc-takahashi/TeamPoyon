using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    Ray ray;
    GameObject clickObject; //クリックしたオブジェクト取得
    public GameObject soilder; //護衛選択

    public GameObject soilderIn; //生成するオブジェクト

	void Start ()
    {

	}

	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //レイをカメラから飛ばす
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if(hit.collider)
            {
                clickObject = hit.collider.gameObject;

                if (clickObject == soilder)
                {
                    Debug.Log("OK");
                }
            }
        }
    }
}
