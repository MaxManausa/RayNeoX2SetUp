using FFalcon.XR.Runtime;
using RayNeo;
using RayNeo.Tool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SampleSceneCtrl : MonoBehaviour
{

    public void OnBtnClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    //void Update()
    //{
    //    Vector3 MoveTarget = Camera.main.transform.TransformPoint(new Vector3(-64,0,446));

    //    m_t.position = MoveTarget;
    //    m_t.LookAt(Camera.main.transform);
    //    m_t.rotation = Camera.main.transform.rotation;// FfalconApi.TransformDirection(Camera.main.transform);
    //}

    public void OpenBatteryInfo()
    {
        AndroidActivity.OpenSystemMonitoring(AndroidActivity.SystemMonitoringInfoType.ELECTRIC | AndroidActivity.SystemMonitoringInfoType.AVERAGE_ELECTRIC);
    }
    public void CloseBatteryInfo()
    {
        AndroidActivity.CloseSystemMonitoring();
    }


}
