using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearcolumnas : MonoBehaviour
{
    public GameObject MyColumn;
    private esfera sphere;
    public Transform RefPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("ColumnCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    void CrearColumna (){
        float Random1 = Random.Range(-10,10);
        float Random2 = Random.Range(-10,10);
        Vector3 DestPos = new Vector3(Random1 ,0 , Random2);
        Vector3 NewPos = RefPos.position + DestPos;

        Instantiate(MyColumn, NewPos, Quaternion.identity);
          print(NewPos);
    }

    IEnumerator ColumnCoroutine(){
        for (int n=0; ;n++){
        CrearColumna();
       }
        yield return new WaitForSeconds(2);
        }
    }



