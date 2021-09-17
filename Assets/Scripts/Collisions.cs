using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
   // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Entity"))
         {
          switch(collision.GetComponent<Entity>().entityType)
          {
               case Entity.EntityTypes.loot:
               Destroy(collision.gameObject);
               break;
            
               case Entity.EntityTypes.rock:
               EndGameM.Instance.FinishGame();
               Debug.Log("You lost!");
                break;
          }
        }
    }
}
