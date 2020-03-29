using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMask : MonoBehaviour {
    public GameObject glasses;
    public GameObject foxMask;
    public GameObject horseMask; 
	
    public void ChooseGlasses()
    {
        glasses.SetActive(true);
        foxMask.SetActive(false);
        horseMask.SetActive(false);
    }

    public void ChooseFox()
    {
        glasses.SetActive(false);
        foxMask.SetActive(true);
        horseMask.SetActive(false);
    }

    public void ChooseHorse()
    {
        glasses.SetActive(false);
        foxMask.SetActive(false);
        horseMask.SetActive(true);
    }


}
