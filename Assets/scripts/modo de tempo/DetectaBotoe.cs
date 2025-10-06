using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class DetectaBotoesVR : MonoBehaviour
{
    // Vai receber os controles do VR
    public InputActionProperty gripAction;      // Aperto do grip
    public InputActionProperty triggerAction;   // Gatilho
    public InputActionProperty trigger2Action;   // Gatilho
    public InputActionProperty primaryButton;  // Botão A/B (ou Touchpad no Vive)
    public InputActionProperty secondaryButton; // Outro botão (B, ou botões do controle)

    void OnEnable()
    {
        // Assina os eventos de ação para os inputs
        gripAction.action.Enable();
        triggerAction.action.Enable();
        trigger2Action.action.Enable();
        primaryButton.action.Enable();
        secondaryButton.action.Enable();
    }

    void OnDisable()
    {
        // Desabilita os eventos de ação quando o script desabilitar
        gripAction.action.Disable();
        triggerAction.action.Disable();
        trigger2Action.action.Disable();
        primaryButton.action.Disable();
        secondaryButton.action.Disable();
    }

    void Update()
    {
        // Mostra no Console os valores dos botões quando pressionados
        //if (gripAction.action.triggered)
        //    Debug.Log("Grip pressionado!");

        //if (triggerAction.action.triggered)
        //    Debug.Log("Trigger pressionado!");
        
        //if (trigger2Action.action.triggered)
        //    Debug.Log("Trigger pressionado!");

        //if (primaryButton.action.triggered)
        //    Debug.Log("Botão primário pressionado! (A/B)");

        //if (secondaryButton.action.triggered)
        //    Debug.Log("Botão secundário pressionado! (B/Outro)");

        //// Você pode também verificar os valores contínuos de alguns controles analógicos (como o Trigger)
        //float triggerValue = triggerAction.action.ReadValue<float>();
        //Debug.Log($"Valor do Trigger: {triggerValue}");

        //float trigger2Value = trigger2Action.action.ReadValue<float>();
        //Debug.Log($"Valor do Trigger: {triggerValue}");
    }
}
