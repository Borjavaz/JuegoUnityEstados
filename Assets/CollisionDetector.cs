using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    //cuando empieza la colision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("La bola tocó al cubo.");
        }
    }

    //mientras esta colisionando
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisionando -> (la bola esta tocando el cubo)");
        }
    }

    //cuando la colision termina
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("La bola se separó del cubo.");
        }
    }
}