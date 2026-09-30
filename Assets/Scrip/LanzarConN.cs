using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

[RequireComponent(typeof(Rigidbody))]
public class LanzarConN : MonoBehaviour
{
    public float fuerza = 8f;
    public bool soloSiEstaAgarrado = false;

    private Rigidbody rb;
    private XRGrabInteractable grab;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        grab = GetComponent<XRGrabInteractable>();
    }

    void Update()
    {
        if (Keyboard.current == null) return;
        if (!Keyboard.current.nKey.wasPressedThisFrame) return;
        if (soloSiEstaAgarrado && !grab.isSelected) return;

        // Si está agarrado, primero lo suelta
        if (grab.isSelected && grab.firstInteractorSelecting is IXRSelectInteractor interactor)
            grab.interactionManager.SelectExit(interactor, grab);

        rb.isKinematic = false;
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Camera.main.transform.forward * fuerza, ForceMode.VelocityChange);
    }
}