using UnityEngine;

public class Shop : MonoBehaviour {


    BuildManager buildManager;
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;


    private void Start()
    {
        buildManager = BuildManager.instance;    
    }


    public void SelectStandardTurret ()
    {
        buildManager.SelectTurretToBuild(standardTurret);


    }

    public void SelectMissileLauncher()
    {

        buildManager.SelectTurretToBuild(missileLauncher);

    }



}
