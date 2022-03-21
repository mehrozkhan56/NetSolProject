using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wrld;
using Wrld.Space;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    //public Transform camera = null;

    void Start()
    {
        //Api.Instance.CameraApi.MoveTo(cameraLocation, distanceFromInterest: 400, headingDegrees: 0, tiltDegrees: 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeBox(LatLong latLong)
    {
        //var ray = Api.Instance.SpacesApi.LatLongToVerticallyDownRay(latLong);
        //LatLongAltitude buildingIntersectionPoint;
        //var didIntersectBuilding = Api.Instance.BuildingsApi.TryFindIntersectionWithBuilding(ray, out buildingIntersectionPoint);
        //if (didIntersectBuilding)
        //{
        //    var boxAnchor = Instantiate(boxPrefab) as GameObject;
        //    boxAnchor.GetComponent<GeographicTransform>().SetPosition(buildingIntersectionPoint.GetLatLong());

        //    var box = boxAnchor.transform.GetChild(0);
        //    box.localPosition = Vector3.up * (float)buildingIntersectionPoint.GetAltitude();
        //    Destroy(boxAnchor, 2.0f);
        //}
    }
}
