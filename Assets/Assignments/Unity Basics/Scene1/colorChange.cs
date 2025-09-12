using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    [SerializeField] private Renderer myObject;
    // Start is called before the first frame update
    void Start()
    {
        myObject.material.color = Random.ColorHSV(0f, 1f, 0.5f, 1f, 0.5f, 1f);;
    }
}
