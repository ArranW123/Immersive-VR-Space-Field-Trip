using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRRayInteractor))]
public class RayController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool forceToggle = false;
    public XRDirectInteractor directInteractor = null;
    private XRRayInteractor rayInteractor = null;
    private bool hasSwitched = false;

    private void Awake()
    {
        rayInteractor = GetComponent<XRRayInteractor>();
        SwitchInteractors(false);
    }

    public void ActivateRay()
    {
        if (!TouchingObject() || forceToggle)
            SwitchInteractors(true);
    }

    public void DeactivateRay()
    {
        if (hasSwitched)
            SwitchInteractors(false);
    }

    private bool TouchingObject()
    {
        List<IXRInteractable> targets = new List<IXRInteractable>();
        directInteractor.GetValidTargets(targets);
        return (targets.Count > 0);
    }

    private void SwitchInteractors(bool value)
    {
        hasSwitched = value;
        rayInteractor.enabled = value;
        directInteractor.enabled = !value;
    }
}
