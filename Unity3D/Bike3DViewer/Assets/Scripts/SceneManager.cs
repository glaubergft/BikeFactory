using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Color currentColor;
    public Transform mountain_bike;
    public Transform road_bike;

    public float RotationSpeed = 0;
    public Transform BikesContainer;

    private BikeManager currentBike;


    private void Start()
    {
        //StartCoroutine(Test_Coroutine());
    }

    private IEnumerator Test_Coroutine()
    {
        SelectBike("mountain_bike");
        ChangeBikeColor("255,0,0");

        yield return new WaitForSeconds(1);

        AdjustHeightFromGround("0.8");

        yield return new WaitForSeconds(1);

        AdjustHeightFromGround("1.2");

        DefineRotation("50");

        yield return new WaitForSeconds(1);

        AdjustSeatHeight("0");

        yield return new WaitForSeconds(1);

        SelectFrontSuspension("true");
        SelectRearSuspension("false");

        yield return new WaitForSeconds(1);

        SelectFrontSuspension("false");
        SelectRearSuspension("true");

        yield return new WaitForSeconds(1);

        SelectFrontSuspension("false");
        SelectRearSuspension("false");

        yield return new WaitForSeconds(1);

        DefineRotation("0");

        DefineSpeed("50");
    }

    void Update()
    {
        BikesContainer.Rotate(0, RotationSpeed * Time.deltaTime, 0);
        //var newRotation = new Quaternion(0, BikesContainer.rotation.y + RotationSpeed, 0, BikesContainer.rotation.w);
        //BikesContainer.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * RotationSpeed2);
    }

    public void SelectBike(string bike)
    {
        mountain_bike.gameObject.SetActive(false);
        road_bike.gameObject.SetActive(false);
        if (bike == "mountain_bike")
        {
            mountain_bike.gameObject.SetActive(true);
            currentBike = mountain_bike.GetComponent<BikeManager>();
        }
        else if (bike == "road_bike")
        {
            road_bike.gameObject.SetActive(true);
            currentBike = road_bike.GetComponent<BikeManager>();
        }
    }

    public void DefineRotation(string speed)
    {
        RotationSpeed = float.Parse(speed);
    }

    public void DefineSpeed(string speed)
    {
        currentBike.Speed = float.Parse(speed);
    }

    public void AdjustSeatHeight(string height)
    {
        currentBike.SeatAdjust = float.Parse(height);
    }

    public void AdjustHeightFromGround(string height)
    {
        currentBike.HeightAdjust = float.Parse(height);
    }

    public void SelectFrontSuspension(string select)
    {
        currentBike.Front_Sup_Structure.gameObject.SetActive(bool.Parse(select));
        UpdateObjectsColor();
    }

    public void SelectRearSuspension(string select)
    {
        bool rearSelected = bool.Parse(select);
        currentBike.Rear_Sup_Structure.gameObject.SetActive(rearSelected);
        currentBike.No_Rear_Sup_Structure.gameObject.SetActive(!rearSelected);
        UpdateObjectsColor();
    }

    public void ChangeBikeColor(string rgb)
    {
        string[] split = rgb.Split(',');
        float r = float.Parse(split[0]) / 255;
        float g = float.Parse(split[1]) / 255;
        float b = float.Parse(split[2]) / 255;

        currentColor = new Color(r, g, b);
        UpdateObjectsColor();
    }

    private void UpdateObjectsColor()
    {
        var coloredObjects = GameObject.FindGameObjectsWithTag("ColoredObject");

        foreach (GameObject go in coloredObjects)
        {
            foreach(var material in go.GetComponent<Renderer>().materials)
            {
                if (material.name.Contains("custom"))
                {
                    material.color = currentColor;
                }
            }
            
        }
    }


}
