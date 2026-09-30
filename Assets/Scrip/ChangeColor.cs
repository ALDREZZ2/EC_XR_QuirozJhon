using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer rend;

    void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void CambiarColor()
    {
        rend.material.color = Random.ColorHSV(0f, 1f, 0.7f, 1f, 0.8f, 1f);
    }
}