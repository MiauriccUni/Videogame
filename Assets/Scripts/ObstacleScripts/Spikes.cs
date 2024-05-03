// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// //https://www.youtube.com/watch?v=ynH51MiKutY 
// public class Spikes : MonoBehaviour
// { 
//
//     private void Start ()
//     {
//         rb = GetComponent <Rigidbody2D> ();
//         anim = GetComponent <Animator>;
//     }
//         
//         private void OnCollisionEnter2D (Collision2D collision) 
//         {
//             if (collision.gameObject.CompareTag ("Trap"))
//             {
//                 Die();
//             }
//         }
//         private void Die ()
//         {
//             rb.bodyType = RigidbdyType2D.Static;
//             anim.SetTrigger ("death");
//         }
//         private void RestartLevel ()
//         {
//             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//         }
//     
// }
