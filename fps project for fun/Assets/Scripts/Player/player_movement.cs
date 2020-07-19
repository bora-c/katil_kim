using System;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 1;
    public CharacterController player;

    public void Move(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        player.transform.position += movement * speed * Time.deltaTime;
    }
    private void Update() {
        Move();
    }
}
