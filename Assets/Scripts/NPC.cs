using UnityEngine;
using System;

public class NPC : MonoBehaviour
{
    public event Action EnteredSpace;
    public event Action DialogEmpty;

    private void Start()
    {
        BlankText();
    }
    private void TalkToPlayer()
    {
        EnteredSpace?.Invoke();
    }

    private void BlankText()
    {
        DialogEmpty?.Invoke();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Player entered");
            TalkToPlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BlankText();
        }
    }
}
