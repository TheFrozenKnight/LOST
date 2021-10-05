using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public GameObject pickups;
    PlayerMovement player;
    private void Start()
    {
        player = GetComponentInChildren<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pickups.SetActive(true);
            this.gameObject.SetActive(false);
            player.picks++;
        }
    }
}
