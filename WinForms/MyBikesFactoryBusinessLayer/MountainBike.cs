using MyBikesFactoryBusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactoryBusinessLayer
{
    [Serializable]
    public class MountainBike : Bike
    {
        private SuspensionType suspension;
        private float heightFromGround;

        public SuspensionType Suspension { get => suspension; set => suspension = value; }
        public float HeightFromGround { get => heightFromGround; set => heightFromGround = value; }
        
        public MountainBike()
        {
            type = BikeType.MountainBike;
        }

        public MountainBike(SuspensionType suspension, float heightFromGround) : this()
        {
            this.suspension = suspension;
            this.heightFromGround = heightFromGround;
        }

        public MountainBike(string serialNumber, string made, string model, DateTime madeDate, Color bikeColor)
            : base(serialNumber, made, model, madeDate, bikeColor)
        {
            type = BikeType.MountainBike;
        }

        public MountainBike(string serialNumber, string made, string model, DateTime madeDate, Color bikeColor, SuspensionType suspension, float heightFromGround)
            : this(serialNumber, made, model, madeDate, bikeColor)
        {
            this.suspension = suspension;
            this.heightFromGround = heightFromGround;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tSuspension:{suspension.ToString()}\tHeightFromGround:{heightFromGround.ToString()}";
        }

        public override ListViewItem ToListViewItem()
        {
            var listItem = base.ToListViewItem();
            listItem.SubItems.Add($"Suspension:{suspension.ToString()}");
            listItem.SubItems.Add($"HeightFromGround:{heightFromGround.ToString()}cm");
            return listItem;
        }
    }
}
