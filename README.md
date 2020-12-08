# location 인식 코드

using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Android;
using System.Diagnostics;
 
```c

public class GPSmove : MonoBehaviour
{
 
    public Text gpsOut ;
    public bool isUpdating;
    private double ini_x;
    private double ini_z;
   
    // Start is called before the first frame update
    void Start()
    {
 
        StartCoroutine(IniLocation());
        StopCoroutine(IniLocation());
        new WaitForSeconds(3);
    }
 
    // Update is called once per frame
    void Update()
    {
        if (!isUpdating)
        {
            StartCoroutine(GetLocation());
            isUpdating = !isUpdating;
        }
    }
    IEnumerator IniLocation()
    {
        
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            UnityEngine.Debug.Log("no gps");
        yield return new WaitForSeconds(3);
 
        // Start service before querying location
        Input.location.Start();
 
        // Wait until service initializes
        int maxWait = 3;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
 
        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            gpsOut.text = "Timed out";
            print("Timed out");
            yield break;
        }
 
        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            gpsOut.text = "Unable to determine device location";
            print("Unable to determine device location");
            yield break;
        }
        else
        {
 
            ini_z = Input.location.lastData.latitude;
            ini_x = Input.location.lastData.longitude;
 
            TextMesh textObject = GameObject.Find("gpsOut").GetComponent<TextMesh>();
            textObject.text = "Initial location" + ini_z + " " + ini_x;
 
 
        }
        Input.location.Stop();
 
        // Stop service if there is no need to query location updates continuously
 
 
 
    }
    
    IEnumerator GetLocation()
    {
   
 
        // Start service before querying location
        Input.location.Start();
 
        // Wait until service initializes
        int maxWait = 3;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
 
        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            gpsOut.text = "Timed out";
            print("Timed out");
            yield break;
        }
 
        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            gpsOut.text = "Unable to determine device location";
            print("Unable to determine device location");
            yield break;
        }
        else
        {
            float z = latToZ(Input.location.lastData.latitude);
            float x = lonToX(Input.location.lastData.longitude);
            TextMesh textObject = GameObject.Find("gpsOut").GetComponent<TextMesh>();
            textObject.text = "location" + z +" "+ x;
            
            // Access granted and location value could be retrieved
           
            this.transform.position = new Vector3(x, 2.5f, z);
 
        }
 
        // Stop service if there is no need to query location updates continuously
        isUpdating = !isUpdating;
        //Input.location.Stop();
    }
    
    float latToZ(double lat)
    {
 
        lat = (lat - ini_z) * 100000;
        double z = lat;
 
        return (float)z;
    }
 
    float lonToX(double lon)
    {
 
        lon = (lon - ini_x) * 10000;
        double x = lon;
 
        return (float)x;
    }
 
}
```
 
 
