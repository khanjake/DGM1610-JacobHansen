using System;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer controlledSprite;
    public Color offColor = Color.red;
    public Color spriteColor = Color.red;
    void Start()
    {
        controlledSprite = GetComponent<SpriteRenderer>();
        controlledSprite.color = spriteColor;
    }

    private void OnEnable()
    {
        print("This is on");
        controlledSprite.color = spriteColor;
    }

    private void OnDisable()
    {
        controlledSprite.color = offColor;
    }

    void Update()
    {
        
    }
}
