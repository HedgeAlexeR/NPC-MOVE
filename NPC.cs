using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5; //здоровье
    public int level = 1; //уровень
    public float speed = 1.2f; //скорость
    public Vector3 newPosition;
    void Start()
    {
        health = health+level;
        print(health); //больше здоровья
    }
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition; //двигать
    }
}
