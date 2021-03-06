﻿
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    
    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;


    

    private Renderer rend;
    private Color startColor;


    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }


    public Vector3 GetBuildPossition()
    {
        return transform.position + positionOffset;
    }
    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;


        if (turret != null)
        {
            Debug.Log("Can't Build There Anymore TODO - Change to upgrades");
            return;
        }

        //Build a turret

        buildManager.BuildTurretOn(this);
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
        
        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }   else
        {
            rend.material.color = notEnoughMoneyColor;
        }
                
    }


    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
