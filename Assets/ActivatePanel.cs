using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel : MonoBehaviour
{
        [SerializeField] private GameObject objectToActivate;
        [SerializeField] private GameObject objectToDeactivate;
        
    public void TransitionToNextPanel()
        {

            objectToActivate.SetActive(true);
            objectToDeactivate.SetActive(false);
            
           
    }

 }
