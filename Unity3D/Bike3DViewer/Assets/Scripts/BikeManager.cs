using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeManager : MonoBehaviour
{
    public enum BikeType
    {
        MountainBike,
        RoadBike
    }

    public BikeType Type;

    public float Speed = 0;

    public Transform Seat;
    public float SeatAdjust = 0;
    public Transform seat_lowest_pos;
    public Transform seat_highest_pos;

    public Transform Front_Sup_Structure;
    public Transform Rear_Sup_Structure;
    public Transform No_Rear_Sup_Structure;

    public float HeightAdjust = 1;
    public Transform Resizible_Structure;
    public Transform Front_Wheel_Pos;
    public Transform Rear_Wheel_Pos;
    public Transform Front_Wheel;
    public Transform Rear_Wheel;

    public Transform Groud;
    public float GroundMoveFactor = 0.11f;

    private float GroundedWheelPosY;

    public float TimeAdjustAnimation = 5;

    // Start is called before the first frame update
    void Start()
    {
        GroundedWheelPosY = Front_Wheel.position.y;
    }

    
    void Update()
    {
        if (Type==BikeType.MountainBike)
        {
            //Update Bike height from ground:
            UpdateHeightFromGround();
        }
        else if(Type==BikeType.RoadBike)
        {
            //Adjust Seat positioning:
            UpdateSeatPos();
        }

        UpdateWheelsRotation();
    }

    void UpdateHeightFromGround()
    {
        //var newHeight = Mathf.Lerp(Resizible_Structure.localScale.y, HeightAdjust, Time.deltaTime * TimeAdjustAnimation);
        var newHeight = HeightAdjust;

        var newBikeScale = new Vector3(Resizible_Structure.localScale.x, newHeight, Resizible_Structure.localScale.z);
        Resizible_Structure.localScale = newBikeScale;

        //Resize trick:
        Front_Wheel.position = Front_Wheel_Pos.position;
        Rear_Wheel.position = Rear_Wheel_Pos.position;

        var currentBikePosition = transform.position;

        //Ground the Bike:
        if (Front_Wheel.position.y != GroundedWheelPosY)
        {
            var heightDiff = GroundedWheelPosY - Front_Wheel.position.y;
            currentBikePosition.y += heightDiff;
            transform.position = currentBikePosition;
        }
    }

    void UpdateSeatPos()
    {
        //Vector v calculation:
        var x1 = seat_lowest_pos.position.x;
        var y1 = seat_lowest_pos.position.y;
        var x2 = seat_highest_pos.position.x;
        var y2 = seat_highest_pos.position.y;
        var v = new Vector2(x2 - x1, y2 - y1);

        //Unit vector u calculation:
        var lenghtOfV = Mathf.Sqrt(Mathf.Pow(x2 - x1, 2) + Mathf.Pow(y2 - y1, 2));
        var u = 1 / lenghtOfV * v;

        //Adjust Seat positioning:
        var newV2Position = new Vector2(seat_lowest_pos.position.x, seat_lowest_pos.position.y);
        newV2Position = newV2Position + (u * lenghtOfV * SeatAdjust);
        var newV3Position = new Vector3(newV2Position.x, newV2Position.y, Seat.position.z);
        Seat.position = Vector3.Lerp(Seat.position, newV3Position, Time.deltaTime * TimeAdjustAnimation);
    }

    void UpdateWheelsRotation()
    {
        Front_Wheel.Rotate(Speed * Time.deltaTime * 10, 0, 0);
        Rear_Wheel.Rotate(Speed * Time.deltaTime * 10, 0, 0);

        var groundOffset = Groud.GetComponent<Renderer>().material.mainTextureOffset;
        groundOffset.y -= Speed * Time.deltaTime * GroundMoveFactor;
        Groud.GetComponent<Renderer>().material.mainTextureOffset = groundOffset;
        //Rear_Wheel
    }
}
