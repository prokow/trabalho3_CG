using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GrabItem : XRGrabInteractable
{
    private Outline outline;

    [Header("Efeito Sonoro ao pegar o item")]
    [SerializeField] private AudioClip soundEffect;
    private AudioSource audioSource;

    protected override void Awake()
    {
        base.Awake();
        outline = GetComponent<Outline>();
        outline.enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        outline.enabled = true;
        outline.OutlineMode = Outline.Mode.OutlineAll;
        outline.OutlineColor = Color.yellow;
        outline.OutlineWidth = 8.0f;
    }

    protected override void OnHoverExited(HoverExitEventArgs args)
    {
        base.OnHoverExited(args);
        //outline.enabled = false;
        outline.OutlineMode = Outline.Mode.OutlineHidden;
        outline.OutlineWidth = 0.0f;

    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        SomItem();
    }


    void SomItem()
    {
        audioSource.PlayOneShot(soundEffect, 2.0f);
    }

}
