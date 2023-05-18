using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketController : XRSocketInteractor
{

    public string targetTag = string.Empty;
    
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);
    }
    
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchUsingTag(interactable);
    }

    private bool MatchUsingTag(XRBaseInteractable interactable) // Checks the interactable if the interactable's tag is the same as "targetTag"
    {
        return interactable.CompareTag(targetTag);
    }

}
