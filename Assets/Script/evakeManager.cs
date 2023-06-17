using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evakeManager : MonoBehaviour
{
    public GameObject toRotate;
    public GameObject player;
    public float rotateSpeed;

    public GameObject[] Player { get; private set; }

    private void FixidUbdate()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");       
        toRotate.transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
        player.transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }
}
