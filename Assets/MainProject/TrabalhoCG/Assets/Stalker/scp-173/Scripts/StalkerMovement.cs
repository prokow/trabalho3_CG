using UnityEngine;

public class StalkerMovement : MonoBehaviour
{
    private Animator animator;
    private float timeHolder;
    [SerializeField] private float timerAnimation = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        timeHolder = timerAnimation;

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
        
    }
}
