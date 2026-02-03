using UnityEngine;
using UnityEngine.AI;

public class StalkerMovement : MonoBehaviour
{
    [Header("Animação do Stalker")]
    private Animator animator;
    private float timeHolder;
    [SerializeField] private float timerAnimation = 1.0f;


    [Header("NavMesh de IA")]
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;

    [Header("Efeito sonoro do Stalker")]
    //[SerializeField] private AudioClip somBichao;
    private AudioSource audioSource;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        timeHolder = timerAnimation;

        audioSource = GetComponent<AudioSource>();
    }




    // Update is called once per frame
    void Update()
    {
        timerAnimation -= Time.deltaTime;
        if(timerAnimation < 0.0f)
        {
            animator.SetTrigger("Animation");
            timerAnimation = timeHolder;

            //animator.transform.forward = transform.forward;
        }

        if(player != null)
        {
            agent.SetDestination(player.position);
        }
        
       

      
    }
}
