using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowItem : MonoBehaviour
{
    [SerializeField]
    private GameObject visualUI;
    [SerializeField]
    private InputActionReference actionValue;
    [SerializeField]
    private TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        float press = actionValue.action.ReadValue<float>();

        if(press > 0.1f)
        {
            visualUI.SetActive(true);
            AtualizarTexto();
        } else
        {
            visualUI.SetActive(false);
        }
    }

    void AtualizarTexto()
    {
        int monster = GameManager.Instance.collectedMonster;

        if(monster < 5)
        {
            text.text = $"{monster} / 5 LATA'S MONSTER'S";
        }
        else
        {
            text.text = "CORRA PARA O ELEVADOR";
        }
    }

}
