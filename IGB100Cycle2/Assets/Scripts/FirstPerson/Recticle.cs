using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recticle : MonoBehaviour
{
    private RectTransform reticle;

    [Range(50f, 250)]
    public float size;

    private void Start()
    {
        reticle = GetComponent<RectTransform>();
    }

    private void Update() 
    {
        reticle.sizeDelta = new Vector2(size,size);
    }
}
