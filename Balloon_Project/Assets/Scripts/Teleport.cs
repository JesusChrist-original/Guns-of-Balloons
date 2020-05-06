using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tl;
    public GameObject Player;
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Player")
        {
            CharacterController cc = Player.GetComponent<CharacterController>();

            cc.enabled = false;
            Player.transform.position = tl.transform.position;
            cc.enabled = true;
        }
    }
}
