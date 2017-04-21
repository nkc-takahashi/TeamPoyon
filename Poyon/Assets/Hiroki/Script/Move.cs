using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    Vector3 startPosition;

    public float amplitude;
    public float speed;

    void Start()

    {
        startPosition = transform.localPosition;
    }

    void Update()
    {
        //変位を計算
        float x = amplitude * Mathf.Sin(Time.time * speed);

        //ｙを変位させたポジションに再設定
        transform.localPosition = startPosition + new Vector3(0, 0, x);
        //GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, y*1000));
    }
}