using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
 private int Dreft =0;
 private int Slinko = 0;

 private void OnTriggerEnter2D(Collider2D collision) 
 {
  if(collision.gameObject.CompareTag("Collectable1"))
  {
   Destroy(collision.gameObject);
   Dreft++;
   Debug.Log("Money: " + Dreft);
 }
 if (collision.gameObject.CompareTag("Collectable2"))
        {
            Destroy(collision.gameObject);
            Slinko++;
            Debug.Log("Slinkies: " + Slinko);
        }
    }
}
