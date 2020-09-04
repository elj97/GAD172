using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject Light;
    public bool LightActive;
    void Start()
    {
        Light.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            LightActive = !LightActive;
        }

        if(LightActive)
        {
            TorchlightActive();
        }

        if(!LightActive)
        {
            TorchlightInactive();
        }
    }

    void TorchlightActive()
    {

        Light.SetActive(true);
    }

    void TorchlightInactive()
    {
        Light.SetActive(false);
    }
}
