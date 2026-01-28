using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class PegarItem : XRGrabInteractable
{
    private XRGrabInteractable interactable;

    protected override void Awake()
    {
        base.Awake();
        interactable = GetComponent<XRGrabInteractable>();

        if (interactable != null)
        {
            interactable.selectEntered.AddListener(OnGrab);
        }
    }
    

     void OnGrab(SelectEnterEventArgs args)
    {
        interactable.selectEntered.RemoveListener(OnGrab);
        Destroy(gameObject);
    }

 
}
