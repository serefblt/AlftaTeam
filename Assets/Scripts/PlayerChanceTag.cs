using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChanceTag : MonoBehaviour
{
    [SerializeField] GameObject _player;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            collision.gameObject.tag = "Player2";
        }
    }
}
