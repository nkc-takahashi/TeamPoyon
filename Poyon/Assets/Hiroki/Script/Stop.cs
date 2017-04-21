using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    Rigidbody2D rb;
    public int moveSpeed = 2;

    void Start()
    {
        //GetComponentの処理をキャッシュしておく
        rb = GetComponent<Rigidbody2D>();
    }
}