using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    private void Start() {
        isInRange = false;
        interactKey = KeyCode.E;
    }

    private void Update() {
        if(isInRange){
            if(Input.GetKeyDown(interactKey)){
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            isInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")){
            isInRange = false;
        }
    }
}
