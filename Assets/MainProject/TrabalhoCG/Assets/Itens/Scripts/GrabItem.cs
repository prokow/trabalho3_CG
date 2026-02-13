using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GrabItem : XRGrabInteractable
{
    private Outline outline;

    [Header("Efeito Sonoro ao pegar o item")]
    [SerializeField] private AudioClip soundEffect;

    public TextMeshProUGUI textGrab;

    protected override void Awake()
    {
        base.Awake();
        outline = GetComponent<Outline>();
        outline.enabled = false;

        textGrab.enabled = false;
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        outline.enabled = true;
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 8.0f;
        textGrab.enabled = true;
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);

        outline.OutlineMode = Outline.Mode.OutlineHidden;
        outline.OutlineWidth = 0.0f;

        if(textGrab != null)
        {
          textGrab.enabled = false;

        }
    }

    void PickupItem()
    {
        GameManager.Instance.ColectedMonster();
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
      
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        PickupItem();
        textGrab.enabled = false;

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        Destroy(gameObject);
        textGrab.enabled = false;

    }
}
