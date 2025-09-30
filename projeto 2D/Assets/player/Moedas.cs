using UnityEngine;

public class Moedas : MonoBehaviour
{
  
  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.gameObject.CompareTag("Player"))
    {
        other.gameObject.GetComponent<Player>().GanharMoedas();
    }
  }
}
