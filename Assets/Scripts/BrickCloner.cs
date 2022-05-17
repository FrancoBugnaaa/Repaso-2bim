using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float Xoffset;
    public Text useroffset;
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Xoffset = float.Parse(useroffset.text);
    }
    
    public void CloneBrick()
    {
        //el if para hacer que se limitada la cantidad de cubos clonados (asi se hace con un If)
        if(counter == 0)
        {
            Xoffset = float.Parse(useroffset.text);
        }
        if (counter <5)
        {
            GameObject clon;
            clon = Instantiate(brickPrefab);
            //sin el += se clonaria en (-3,0,0) con el +=
            clon.transform.position += new Vector3(Xoffset, 0, 0);
            Xoffset += 1.1f;
            counter++;
        }
        //esto es para que no tengan limite de clonacion de cubos.
        // clon = Instantiate(brickPrefab);
        //sin el += se clonaria en (-3,0,0) con el +=
       // clon.transform.position += new Vector3(Xoffset, 0, 0);
       // Xoffset += 1.1f;
       // counter++;
     
    }
}
