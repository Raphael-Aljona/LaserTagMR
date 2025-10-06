using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class DetectaBotoesVR : MonoBehaviour
{
    // Vai receber os controles do VR
    public InputActionProperty gripAction;      // Aperto do grip
    public InputActionProperty triggerAction;   // Gatilho
    public InputActionProperty trigger2Action;   // Gatilho
    public InputActionProperty primaryButton;  // Bot�o A/B (ou Touchpad no Vive)
    public InputActionProperty secondaryButton; // Outro bot�o (B, ou bot�es do controle)

    void OnEnable()
    {
        // Assina os eventos de a��o para os inputs
        gripAction.action.Enable();
        triggerAction.action.Enable();
        trigger2Action.action.Enable();
        primaryButton.action.Enable();
        secondaryButton.action.Enable();
    }

    void OnDisable()
    {
        // Desabilita os eventos de a��o quando o script desabilitar
        gripAction.action.Disable();
        triggerAction.action.Disable();
        trigger2Action.action.Disable();
        primaryButton.action.Disable();
        secondaryButton.action.Disable();
    }

    void Update()
    {
        // Mostra no Console os valores dos bot�es quando pressionados
        //if (gripAction.action.triggered)
        //    Debug.Log("Grip pressionado!");

        //if (triggerAction.action.triggered)
        //    Debug.Log("Trigger pressionado!");
        
        //if (trigger2Action.action.triggered)
        //    Debug.Log("Trigger pressionado!");

        //if (primaryButton.action.triggered)
        //    Debug.Log("Bot�o prim�rio pressionado! (A/B)");

        //if (secondaryButton.action.triggered)
        //    Debug.Log("Bot�o secund�rio pressionado! (B/Outro)");

        //// Voc� pode tamb�m verificar os valores cont�nuos de alguns controles anal�gicos (como o Trigger)
        //float triggerValue = triggerAction.action.ReadValue<float>();
        //Debug.Log($"Valor do Trigger: {triggerValue}");

        //float trigger2Value = trigger2Action.action.ReadValue<float>();
        //Debug.Log($"Valor do Trigger: {triggerValue}");
    }
}
