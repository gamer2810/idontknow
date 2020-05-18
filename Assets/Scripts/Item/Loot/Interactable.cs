using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class InventoryEvent : UnityEvent<InventoryObject> {}

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    
    [SerializeField] public InventoryEvent interactAction = null;

    private InventoryObject invokerInventory = null; 

    private void Start() {
        isInRange = false;
        interactKey = KeyCode.E;
    }

    private void Update() {
        if(isInRange){
            if(Input.GetKeyDown(interactKey)){
                interactAction.Invoke(invokerInventory);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            isInRange = true;
            invokerInventory = other.GetComponent<Entity>().inventory;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            isInRange = false;
            invokerInventory = null;
        }
    }
}
