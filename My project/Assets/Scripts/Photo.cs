using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photo : MonoBehaviour

    
{
    public GameObject photoObject;
    private void Start()
    {
        // Fotoðrafý baþta görünmez yap
        photoObject.SetActive(false);
    }

    public void OnMouseEnterButton()
    {
        // Butonun üzerine gelindiðinde fotoðrafý görünür yap
        photoObject.SetActive(true);
    }

    public void OnMouseExitButton()
    {
        // Butondan ayrýldýðýnda fotoðrafý görünmez yap
        photoObject.SetActive(false);
    }

}
