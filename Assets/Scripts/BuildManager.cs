using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;

    void Awake()
    {
       if (instance != null)
        {
            return;
        }
        instance = this;  
    }


    public GameObject standardTurretPrefab;
    public GameObject missileLauncherTurret;
   

    private TurretBlueprint turretToBuild;
    

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
    
    public void BuildTurretOn(Node node)
    {
        
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not Enough Money");
                return;
        }

        PlayerStats.Money -= turretToBuild.cost;
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPossition(), Quaternion.identity);

        node.turret = turret;

    }
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }


}
