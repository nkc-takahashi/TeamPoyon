using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atarihanteiyatu : MonoBehaviour
{
    public int status;
    public Text statusUI;
    private void Start()
    {
        status = 0;
    }
    private void Update()
    {
        if(status == 0)
        {
            statusUI.text = "白";
        }
        else
        {
            statusUI.text = "黒";
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "Wall")
        {
            status =1;
        }
    }
}