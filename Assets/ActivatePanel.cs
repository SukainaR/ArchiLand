using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePanel : MonoBehaviour
{
        [SerializeField] private GameObject objectToActivate;

        public void TransitionToNextPanel()
        {

            objectToActivate.SetActive(true);
        }

 }
