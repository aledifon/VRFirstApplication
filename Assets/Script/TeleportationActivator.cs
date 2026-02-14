using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class TeleportationActivator : MonoBehaviour
{
    public XRRayInteractor teleportInteractor;
    public XRRayInteractor rayInteractor;
    public InputActionProperty teleportActivatorAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        teleportInteractor.gameObject.SetActive(false);
        teleportActivatorAction.action.performed += Action_performed;
        // The UIHoverEventArgs sent from uiHoverEntered Event are ignored and
        // the DisableTeleportRay is called through a lambda expression.
        rayInteractor.uiHoverEntered.AddListener(x => DisableTeleportRay());

        // Alternative way in case DisableTeleportRay has the same sign
        //rayInteractor.uiHoverEntered.AddListener(DisableTeleportRay); 
    }

    private void OnDisable()
    {
        teleportActivatorAction.action.performed -= Action_performed;
    }

    public void DisableTeleportRay()
    {
        teleportInteractor.gameObject.SetActive(false);
    }

    // Alternative way in case we make it match with the sign of uiHoverEntered
    //public void DisableTeleportRay(UIHoverEventArgs args)
    //{
    //    teleportInteractor.gameObject.SetActive(false);
    //}

    private void Action_performed(InputAction.CallbackContext obj)
    {
        // In case there is a Ray Interactor over an UI object then
        // the Teleport Interactor won't be enabled.
        if (rayInteractor && rayInteractor.IsOverUIGameObject())
            return;

        teleportInteractor.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (teleportActivatorAction.action.WasReleasedThisFrame())
            teleportInteractor.gameObject.SetActive(false);
    }
}
