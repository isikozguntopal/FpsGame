using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{   
    public bool useEvents;
    //player'ın baktığında cıkacak yazı
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook(){
        return promptMessage;
    }

    //bu fonksiyon player tarafından çağırılan fonksiyon
    public void BaseInteract(){
            if(useEvents)
               GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {

        //Tamplate function
    } 
}
