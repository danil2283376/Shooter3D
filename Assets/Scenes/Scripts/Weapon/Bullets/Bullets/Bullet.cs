using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public BulletsScriptable bulletScriptable;

    private float currentTime = 0.0f;
    void Update()
    {
        if (bulletScriptable.timeLive < currentTime)
            Destroy(gameObject);
        currentTime += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
