using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalMovement : MonoBehaviour
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

        float h = Input.GetAxisRaw("Vertical");

        Vector3 temp = transform.position;

        if (h > 0)
        {
            // going up

            temp.y += speed * Time.deltaTime;



        }
        else if (h < 0)
        {
       //going down
            temp.y -= speed * Time.deltaTime;


        }


        transform.position = temp;

    }

}
