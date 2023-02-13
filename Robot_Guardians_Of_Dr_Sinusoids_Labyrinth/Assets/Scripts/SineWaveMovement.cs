using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveMovement : MonoBehaviour


{
    public GameObject Robot;
    private Rigidbody2D body;
    public float x;
    public float y;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Robot.transform.position;
        x += (Mathf.Sin(Time.time) / 75);
        y += (Mathf.Cos(Time.time) / 70);
        transform.position = new Vector2(x, y);
    }
}