using UnityEngine;

public class Link : MonoBehaviour
{
    // Link que ser� aberto
    public string url = "https://www.youtube.com/watch?v=oHg5SJYRHA0";

    // Fun��o que o bot�o vai chamar
    public void Abrir()
    {
        Application.OpenURL(url);
    }
}


