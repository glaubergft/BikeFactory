using MyBikesFactoryBusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyBikesFactoryBusinessLayer
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    public abstract class Bike : SerializableItem
    {
        protected BikeType type;
        private string serialNumber;
        private string made;
        private string model;
        private double speed;
        private DateTime madeDate;
        private Color bikeColor;
        private BikeState state = BikeState.Stopped;

        public BikeType Type { get => type; } //Read-only (defined via constructors from child classes)
        public string SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Made { get => made; set => made = value; }
        public string Model { get => model; set => model = value; }
        public double Speed { get => speed; } //Readonly (It has to be changed by using Accelerate/Decelerate methods)
        public DateTime MadeDate { get => madeDate; set => madeDate = value; }
        public BikeState State { get => state; set => state = value; }

        [XmlIgnore]
        public Color BikeColor { get => bikeColor; set => bikeColor = value; }

        [XmlElement("BikeColor")]
        public string XmlColor
        {
            get => ColorTranslator.ToHtml(bikeColor);
            set => bikeColor = ColorTranslator.FromHtml(value);
        }
        

        public Bike()
        {
        }

        public Bike(string serialNumber, string made, string model, DateTime madeDate, Color bikeColor)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.madeDate = madeDate;
            this.bikeColor = bikeColor;
        }

        public void Start()
        {
            State = BikeState.Started;
        }

        public void Stop()
        {
            speed = 0;
            State = BikeState.Stopped;
        }

        public void Accelerate(double increment)
        {
            speed += increment;
            State = BikeState.Started;
        }

        public void Decelerate(double decrement)
        {
            if (speed - decrement >=0)
                speed -= decrement;
               
            if (speed == 0)
                State = BikeState.Stopped;
        }

        public override string ToString()
        {
            return $"Type:{type.ToString()}\tSerial Number:{serialNumber}\tMade:{Made}\tModel:{Model}\tColor:{ColorTranslator.ToHtml(bikeColor)}\tMade Date:{madeDate.ToShortDateString()}";
        }

        public virtual ListViewItem ToListViewItem()
        {
            var listItem = new ListViewItem();
            listItem.UseItemStyleForSubItems = false;
            listItem.Text = type.ToString();
            listItem.SubItems.Add(serialNumber);
            listItem.SubItems.Add(made);
            listItem.SubItems.Add(model);
            var colorSubItem = new ListViewItem.ListViewSubItem() { BackColor = bikeColor };
            colorSubItem.ForeColor = bikeColor;
            colorSubItem.Text = ColorTranslator.ToHtml(bikeColor);
            listItem.SubItems.Add(colorSubItem);
            listItem.SubItems.Add(madeDate.ToShortDateString());
            return listItem;
        }
    }
}