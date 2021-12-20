using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float jump = 300f;
    public float jc;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        jc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(jc == 0)
            {
                rb2d.AddForce(Vector2.up * jump);
                jc = 1;
            }else if(jc == 1)
            {
                rb2d.AddForce(Vector2.up * jump);
                jc = 2;
            }
            else
            {

            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jc = 0;
        }
    }
}
