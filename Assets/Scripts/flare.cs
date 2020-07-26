using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class flare : MonoBehaviour
{
    public AnimationCurve FadeCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(1, 0));

    public float _alpha = 1;
    public Texture2D _texture;
    public bool _done;
    public float _time;
    public bool transition;

    public Color fadeColor;

    public void Reset()
    {
        _done = false;
        _alpha = 1;
        _time = 0;
    }

    public void SetColor(Color color)
    {
        fadeColor = color;
    }

    [RuntimeInitializeOnLoadMethod]
    public void RedoFade()
    {
        fadeColor = new Color(255, 255, 255, 1);
        transition = true;
        Reset();
    }

    public void OnGUI()
    {
        if (transition)
        {
            if (_done) { transition = false; return; }
            if (_texture == null) _texture = new Texture2D(1, 1);

            _texture.SetPixel(0, 0, new Color(fadeColor.r,fadeColor.g,fadeColor.b, _alpha));
            _texture.Apply();

            _time += Time.deltaTime;
            _alpha = FadeCurve.Evaluate(_time);
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _texture);

            if (_alpha <= 0) _done = true;
        }
    }
}
