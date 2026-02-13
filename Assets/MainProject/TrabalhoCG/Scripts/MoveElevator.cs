using UnityEngine;

public class MoveElevator : MonoBehaviour
{
    private Animator _dooranimator;
    private BoxCollider _boxCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _dooranimator = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_boxCollider.CompareTag("Player"))
        {
            if(GameManager.Instance.collectedMonster == 5)
            {
                _dooranimator.SetTrigger("Close");
                Debug.Log("lepo");
            }
        }
    }
}
