using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frick : MonoBehaviour {

    Vector2 touchStartPos;
    Vector2 touchEndPos;

    string Direction;
    public float flickJudge;



	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
    }
    void Flick()//フリックの位置を取得
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            touchEndPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
    void GetDirection()//フリックの方向を取得
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;


        if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
        {
            if (flickJudge < directionX)
            {
                //右向きにフリック
                Direction = "right";
            }
            else if (-flickJudge > directionX)
            {
                //左向きにフリック
                Direction = "left";
            }
        }
        else
        {
            //タッチを検出
            Direction = "touch";
        }

        switch (Direction)
        {
            case "right":
                Debug.Log("右フリック"); //右フリックされた時の処理
                break;

            case "left":
                Debug.Log("左フリック");//左フリックされた時の処理
                break;
            case "touch":
                Debug.Log("タッチ");//タッチされた時の処理
                break;
        }

    }
}
