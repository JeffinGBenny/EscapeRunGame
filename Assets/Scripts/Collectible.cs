using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
   private int score=0;
   private void OnTriggerEnter2D(Collider2D collision) {
       if(collision.gameObject.CompareTag("Collectible")){
           score++;
           scoreText.text="Score"+score;
           Destroy(collision.gameObject);
       }
       
   }
}
