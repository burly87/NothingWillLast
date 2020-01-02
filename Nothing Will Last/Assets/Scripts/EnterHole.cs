using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHole : MonoBehaviour
{
    public int LayerOnEnter;
    public int LayerOnExit;

   void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Building")
       {
           other.gameObject.layer = LayerOnEnter;
       }
   }

//    void OnTriggerExit(Collider other)
//    {
//        if(other.gameObject.tag == "Building")
//        {
//            other.gameObject.layer = LayerOnExit;
//        }
//         // can activate Calculation hier 
//       // Destroy(other.gameObject);
//       print("Exit Collider, get points and destroy me later");
//    }
}
