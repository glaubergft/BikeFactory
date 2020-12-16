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
    public class RoadBike : Bike
    {
        private float seatHeight;

        public float SeatHeight { get => seatHeight; set => seatHeight = value; }

        public RoadBike()
        {
            type = BikeType.RoadBike;
        }

        public RoadBike(float seatHeight) : this()
        {
            this.seatHeight = seatHeight;
        }

        public RoadBike(string serialNumber, string made, string model, DateTime madeDate, Color bikeColor)
            : base(serialNumber, made, model, madeDate, bikeColor)
        {
            type = BikeType.RoadBike;
        }

        public RoadBike(string serialNumber, string made, string model, DateTime madeDate, Color bikeColor, float seatHeight)
            : this(serialNumber, made, model, madeDate, bikeColor)
        {
            this.seatHeight = seatHeight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\tSeatHeight:{seatHeight.ToString()}cm";
        }

        public override ListViewItem ToListViewItem()
        {
            var listItem = base.ToListViewItem();
            listItem.SubItems.Add($"SeatHeight:{seatHeight.ToString()}cm");
            return listItem;
        }
    }
}
