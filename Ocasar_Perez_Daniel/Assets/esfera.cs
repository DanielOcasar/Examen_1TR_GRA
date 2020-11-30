using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            float posZ = transform.position.y;
            float desplX = Input.GetAxis("Horizontal");
            float desplZ = Input.GetAxis("Vertical");

            //restringir en el eje x
        if(posX > -10  && posX < 10 || posX < -10 && desplX > 0 || posX > 10 && desplX < 0 )
        { transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }
            //restringir en el eje y
        if(posZ > -10  && posZ < 10 || posZ < -10 && desplZ > 0 || posZ > 10 && desplZ < 0 )
        {   transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);

        }
    }


}
