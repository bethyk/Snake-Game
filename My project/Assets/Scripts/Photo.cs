using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo : MonoBehaviour

    
{
    public GameObject photoObject;
    private void Start()
    {
        // Foto�raf� ba�ta g�r�nmez yap
        photoObject.SetActive(false);
    }

    public void OnMouseEnterButton()
    {
        // Butonun �zerine gelindi�inde foto�raf� g�r�n�r yap
        photoObject.SetActive(true);
    }

    public void OnMouseExitButton()
    {
        // Butondan ayr�ld���nda foto�raf� g�r�nmez yap
        photoObject.SetActive(false);
    }

}
