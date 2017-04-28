using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escortselector : MonoBehaviour
{    
    // 左クリックしたオブジェクトを取得する関数(2D)
    private GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
            if (collition2d)
            {
                result = collition2d.transform.gameObject;
            }
        }
        return result;
    }

    // Use this for initialization
    void Start ()
    {
        		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject obj = getClickObject();
        if (obj != null)
        {
            // 以下オブジェクトがクリックされた時の処理
            //soilderWindows.SetActive(false);
            Debug.Log("ウィンドウを開く");
        }
    }    
}
