using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour, IInteractable
{
    public void Interract()
    {
        Debug.Log("oui");
        GameManager._manager.inspectItem.StartInspecting(this.gameObject);
    }
}
