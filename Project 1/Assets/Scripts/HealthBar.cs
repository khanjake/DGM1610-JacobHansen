using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int totalHP;

    public int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        print(totalHP);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI()
    {
        int w = Screen.width, h = Screen.height;
        GUIStyle style = new GUIStyle();
        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperRight;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        string text = string.Format("{0} HP", currentHP);
        GUI.Label(rect, text, style);
    }
}
