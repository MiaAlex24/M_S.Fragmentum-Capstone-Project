using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Entity entity;

    private void Awake() => entity = GetComponent<Entity>();


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) entity.ToggleActive();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) entity.ToggleActive();
    }
}
