using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wikitude;     

public class Controller : MonoBehaviour
{
    public ImageTracker CarTracker;
    public ImageTracker DinoTracker;

    public GameObject CarPanel;
    public GameObject DinoPanel;

    bool isLoadingTracker = false;

   public void OnTrackCar()
    {
        if(!CarTracker.enabled && !isLoadingTracker)
        {
            isLoadingTracker = true;
            CarPanel.SetActive(true);
            DinoPanel.SetActive(false);
            CarTracker.enabled = true;
        }
    }

    public void OnTrackDino()
    {
        if(!DinoTracker.enabled && !isLoadingTracker)
        {
            isLoadingTracker = true;
            CarPanel.SetActive(false);
            DinoPanel.SetActive(true);
            DinoTracker.enabled = true;
        }
    }

    public void OnTargetLoaded()
    {
        isLoadingTracker = false;   
    }
}
