using UnityEngine;

public class EnemyFollower : MonoBehaviour
{
    public Transform player;
    
    public float detectionRange = 5f;
    
    public float speed = 3f;
    
    //variable q guardar el estado actual
    private string currentState = "Lejos"; // cerca o colisionando

    void Update()
    {
        //si no hay jugador no hace nada
        if (player == null)
        {
            Debug.LogWarning("Asigna el jugador al script EnemyFollower en el Inspector");
            return;
        }

        //calculo la distancia entre el Player y el Enemy
        float distance = Vector3.Distance(transform.position, player.position);

        //estadoss
        if (distance > detectionRange)
        {
            
            currentState = "Lejos";
            Debug.Log("Estado: Lejos -> El cubo está quieto");
        }
        else
        {
            currentState = "Cerca";
            
            //calculo direccion conforme el jugador
            Vector3 direction = (player.position - transform.position).normalized;
            
            //el enemigo se mueve hacia el jugador
            transform.position += direction * speed * Time.deltaTime;
            
            Debug.Log("Estado: Cerca -> El cubo persigue a la bola");
        }
    }
    
    //para ver el rango de deteccion
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}