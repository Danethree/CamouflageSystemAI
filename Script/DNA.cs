using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    public float r,g,b,s;
    public float timeToDie = 0;
    bool dead = false;
    SpriteRenderer sRenderer;
    Collider2D sCollider;
    
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        sRenderer.color = new Color(r, g, b);
        this.transform.localScale = new Vector3(s,s,s);
       
    }

    void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        sRenderer.enabled = false;
        sCollider.enabled = false;
        
    }
}
