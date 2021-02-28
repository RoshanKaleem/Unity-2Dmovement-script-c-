using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class full2dmotion : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 3f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          Move();
    }
    void Move()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 temp = transform.position;

        if (h > 0)
        {
            // going to the right side

            temp.x += speed * Time.deltaTime;



        }
        else if (h < 0)
        {
          //going to left side
            temp.x -= speed * Time.deltaTime;


        }
        if (v > 0)
        {
            // going to the upper  side

            temp.y += speed * Time.deltaTime;



        }
        else if (v < 0)
        {
        //going to lower side
            temp.y -= speed * Time.deltaTime;


        }



        transform.position = temp;

    }

}
