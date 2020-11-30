using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
            
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
            MoverBola();
    }

    void MoverBola(){

        //variables 
            float posX = transform.position.x;
            float posY = transform.position.y;
            float desplX = Input.GetAxis("Horizontal");
            float desplY = Input.GetAxis("Vertical");

            //restringir en el eje x
        if(posX > -10  && posX < 10 || posX < -10 && desplX > 0 || posX > 10 && desplX < 0 )
        { transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
            //restringir en el eje y
        if(posY > -10  && posY < 10 || posY < -10 && desplY > 0 || posY > 10 && desplY < 0 )
        {   transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);

        }
    }

}
