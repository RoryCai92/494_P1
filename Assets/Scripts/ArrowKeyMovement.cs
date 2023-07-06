using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyMovement : MonoBehaviour
{

    Rigidbody rb;
    public int speed_constant = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 input = GetInput();

        rb.velocity = input * speed_constant;

    }


    Vector2 GetInput()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        if(Mathf.Abs(hori) > 0.0f)
        {
            vert = 0.0f;
        }
        return new Vector2(hori, vert);
    }
}
