using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SoundItem : XRGrabInteractable
{

    [SerializeField] private AudioClip som;
    private AudioSource somSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        somSource = GetComponent<AudioSource>();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        if (somSource != null)
        {
            somSource.PlayOneShot(som, 6.0f);
        }
    }
}
