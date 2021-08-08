using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    public GameObject Wall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.enabled)
        {

            Destroy(Wall);
        }
    }
}
