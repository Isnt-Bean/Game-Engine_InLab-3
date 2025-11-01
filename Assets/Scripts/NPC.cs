using UnityEngine;
using System;

public class NPC : MonoBehaviour
{
    public event Action EnteredSpace;

    private void TalkToPlayer()
    {
        EnteredSpace?.Invoke();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player entered");
            TalkToPlayer();
        }
    }
}
