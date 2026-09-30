using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorInteraction : MonoBehaviour
{
    public GameObject exitPanel;

    public void OpenExitPanel(SelectEnterEventArgs args)
    {
        exitPanel.SetActive(true);

        var manager = args.manager;
        manager.SelectExit(args.interactorObject, args.interactableObject);
    }
}