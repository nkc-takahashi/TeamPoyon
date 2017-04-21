using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour {

    Vector2 posLeft;
    Vector2 posRight;
    public float moveWallLeft = 1.0f;
    //public float moveWallRight = 1.0f;
    public GameObject wall;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        MoveWalls();
        
	}

    void MoveWalls()
    {
        //左側の壁が迫ってくる処理
        posLeft = transform.position;
        posLeft.x += moveWallLeft;
        transform.position = posLeft;

        //右側の壁が迫ってくる処理
        posRight = wall.transform.position;
        posRight.x -= moveWallLeft;
        wall.transform.position = posRight;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Soilder")
        {
            moveWallLeft = 0;
        }
    }
}