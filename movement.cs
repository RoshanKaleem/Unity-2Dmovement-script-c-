using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
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

        Vector3 temp = transform.position;

        if (h > 0)
        {
            // going to the right side

            temp.x += speed * Time.deltaTime;



        }
        else if (h < 0)
        {

            temp.x -= speed * Time.deltaTime;


        }


        transform.position = temp;

    }

}
