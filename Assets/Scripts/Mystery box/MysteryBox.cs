using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryBox : MonoBehaviour
{
    private void OnTriggerEnter (Collider other) {
        shell(other.GameObject);
        Destroy(transform.GameObject); // destroy my transform object and it would be miystery box. remove from world space
    } //when colliding, it looks for object collide with it

    private void Shell (GameObject other) {
        other.GetComponent <PlayerMovements>().canShoot = true;
    }
}

