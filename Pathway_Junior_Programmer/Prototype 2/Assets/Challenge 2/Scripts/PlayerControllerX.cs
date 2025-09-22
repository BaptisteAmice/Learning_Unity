using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 1.0f;
    private float lastThrow = -10.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastThrow + cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastThrow = Time.time;
        }
    }
}
