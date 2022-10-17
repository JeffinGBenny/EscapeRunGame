using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sprite : MonoBehaviour
{   private void OnCollisionEnter2D(Collision2D collision) {
    

    // Start is called before the first frame update
   if(collision.gameObject.CompareTag("Player")){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
}
