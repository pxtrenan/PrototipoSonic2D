using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
   private void OnTriggerStay2D(Collider2D collision)
   {
       if (collision.gameObject.CompareTag("Player"))
       {
           Pontos.levelManager.SetMoedas();
           GetComponent<CircleCollider2D>().enabled = false;
           GetComponent<Animator>().SetBool("anelestrela", true);
           StartCoroutine(espera());
       }
   }
   IEnumerator espera()
   {
       yield return new WaitForSeconds(0.4f);
       Destroy(gameObject);
   }
}
