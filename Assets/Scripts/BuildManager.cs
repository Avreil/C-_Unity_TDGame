using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
       
        instance = this;  
    }


    public GameObject standardTurretPrefab;
    public GameObject missileLauncherTurret;
   

    private GameObject turretToBuild;
    



    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }



}
