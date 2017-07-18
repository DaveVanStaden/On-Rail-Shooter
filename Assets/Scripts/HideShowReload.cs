using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowReload : MonoBehaviour {
   // public GameObject EnableDissable = GameObject.FindGameObjectWithTag("reloadMessage");
    private PlayerShoot _playerShoot = new PlayerShoot();
    private void Start()
    {
        GameObject EnableDissable = GameObject.FindGameObjectWithTag("reloadMessage");
        EnableDissable.SetActive(false);
    }

    void Update()
    {
        try
        {
            PlayerShoot ps = new PlayerShoot();
            GameObject EnableDissable = GameObject.FindGameObjectWithTag("reloadMessage");
            EnableDissable = new GameObject();
            //EnableDissable = GameObject.FindGameObjectsWithTag("reloadMessage");
            switch (ps.BulletsInClip)
            {
                case 0:
                    EnableDissable.SetActive(true);
                    break;
                case 1:
                    EnableDissable.SetActive(false);
                    break;
                case 2:
                    EnableDissable.SetActive(false);
                    break;
                case 3:
                    EnableDissable.SetActive(false);
                    break;
                case 4:
                    EnableDissable.SetActive(false);
                    break;
                case 5:
                    EnableDissable.SetActive(false);
                    break;
                case 6:
                    EnableDissable.SetActive(false);
                    break;
                case 7:
                    EnableDissable.SetActive(false);
                    break;
                default:
                    break;
            }
            if (ps.BulletsInClip == 0)
            {
                EnableDissable.SetActive(true);

            }

            if (ps.BulletsInClip > 0)
            {
                EnableDissable.SetActive(false);
            }
        }
        catch(Exception ex)
        {
            ex.ToString();
        }
        
    }
    private string message { get; set; }
    void reloadMessage(bool reload, out string reloadMessage)
    {
        reloadMessage = string.Empty;
        if(reload)
        {
            reloadMessage = "you need to reload";            
        }
    }
}
