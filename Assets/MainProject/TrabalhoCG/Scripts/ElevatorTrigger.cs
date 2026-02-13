using UnityEngine;

public class ElevatorTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator _dooranimator; // Arraste o Animator das portas para cá no Inspector

    // Removi o GetComponent do Start para você poder arrastar manualmente,
    // garantindo que estamos mexendo no objeto certo.

    private void OnTriggerEnter(Collider other)
    {
        // 1. Verifica se quem entrou tem a tag Player
        if (other.CompareTag("Player"))
        {
            // 2. Verifica se a meta de 5 latinhas foi batida no GameManager
            // (Usei 'collectedMonster' conforme o seu código)
            if (GameManager.Instance.collectedMonster >= 5)
            {
                _dooranimator.SetTrigger("Close");
                Debug.Log("lepo - Jogador entrou com as 5 latas. Fechando!");

                // Dica: Você pode desativar o collider aqui para não 
                // disparar o trigger de novo se o player se mexer lá dentro
                GetComponent<BoxCollider>().enabled = false;
            }
            else
            {
                Debug.Log($"Ainda faltam latinhas! Você só tem {GameManager.Instance.collectedMonster}");
            }
        }
    }
}
