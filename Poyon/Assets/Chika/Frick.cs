using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frick : MonoBehaviour {

    Vector2 touchStartPos;
    Vector2 touchEndPos;
    Vector2 princcesPos;

    public GameObject Princces; //動く姫たち
    public float speed; //姫の動くスピード

    string Direction;
    public float flickJudge;//フリックの判定をする値

    public bool Zensin;//前進する＆しないのフラグ

	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Flick();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Flick();
            GetDirection();
        }

        princcesPos = Princces.transform.position;

        if (Zensin == true)
        {
            princcesPos.y += speed;
        }
        else if(Zensin == false)
        {
            princcesPos.y += 0;
        }

        Princces.transform.position = princcesPos;
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
                //右フリックされた時の処理
                if (Zensin == false)
                {
                    Zensin = true;
                }
                else if(Zensin == true)
                {
                    Zensin = false;
                }
                break;

            case "left":
                //左フリックされた時の処理
                if (Zensin == false)
                {
                    Zensin = true;
                }
                else if (Zensin == true)
                {
                    Zensin = false;
                }
                break;

            case "touch":
                break;
        }
    }
}
