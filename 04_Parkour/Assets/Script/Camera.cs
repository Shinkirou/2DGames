using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ��;

    void Start()
    {

    }

    void Update()
    {
        Vector3 CatPos = ��.transform.position;
        transform.position = new Vector3(transform.position.x, CatPos.y, transform.position.z);
    }
}