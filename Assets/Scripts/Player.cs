using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    public event Action ThingHappened;

    public float speed = 5f;
    public void DoThing()
    {
        ThingHappened?.Invoke();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Movement direction
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
