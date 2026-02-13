using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Progressao da Missao")]
    public int collectedMonster = 0;
    public int totalMonster= 5;

    [Header("Referencias")]
    public Animator animator;
    public StalkerMovement bichao;

    public bool endGame = false;
    public GameObject painel;
    public TMPro.TextMeshPro texto;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    public void ColectedMonster()
    {
        collectedMonster = collectedMonster + 1;
        //Debug.Log(collectedMonster);
    }


    public void FinalizarJogo(string msg)
    {
        if (!endGame)
        {
            endGame = true;
            texto.text = msg;

            painel.SetActive(true);
            painel.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2f;
            painel.transform.LookAt(Camera.main.transform.position);
            painel.transform.Rotate(0, 180, 0);
        }
    }
}
