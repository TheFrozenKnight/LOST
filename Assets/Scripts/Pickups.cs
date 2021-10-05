using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public GameObject pickups;
    PlayerMovement player;
    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.picks++;
            pickups.SetActive(true);
            this.gameObject.SetActive(false);
            
        }
    }
}
