using TMPro;
using UnityEngine;

public class ElevatorGuy : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI texto;

    private Transform cam;

    void Start()
    {
        cam = Camera.main.transform;
    }


    void Update()
    {
        if (GameManager.Instance.collectedMonster == 5)
        {
            texto.text = "Finalmente ein, entra ae meu chapa, você ta livre!";
        }
    }


    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
   
    }
}

