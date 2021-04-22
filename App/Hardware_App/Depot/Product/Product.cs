using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class Product
    {
        public static int idHelper;
        private int id;
        private string model;
        private string brandName;
        private float price;
        private string description;
        private double weight;
        private double height;
        private double width;
        private double depth;
        private string category;
        private int aisleNumber;
        private int qtyWh;
        private int qtySh;
        private DateTime shipmentDate;
        private Employee registeredEmp;
        private ProductState state;
        private string name;
        private string barcode;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string GetDepotInfo { get { return $"Id: {id} ,Name: {Name} ,Qty: {qtyWh} ,State: {state}"; } }
        public string GetSalesInfo { get { return $"Id: {id} ,Model: {model} ,BrandName: {brandName} ,Price: {price} ,Description: {description} ,Weight: {weight} ,Height: {height} ,Width: {width} ,Depth: {depth} ,Category: {category} ,QtyShelf: {qtySh} ,State: {state}"; } }
        public string BrandName { get { return brandName; } set { brandName = value; } }
        public string Model { get { return model; } set { model = value; } }
        public float Price { get { return price; } set { price = value; } }

        public string Description { get { return description; } set { description = value; } }

        public double Weight { get { return weight; } set { weight = value; } }

        public double Height { get { return height; } set { height = value; } }
        public double Width { get { return width; } set { width = value; } }
        public double Depth { get { return depth; } set { depth = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int AisleNumber { get { return aisleNumber; } set { aisleNumber = value; } }
        public int QuantityWarehouse { get { return qtyWh; } set { qtyWh = value; } }
        public int QuantityShelf { get { return qtySh; } set { qtySh = value; } }
        public DateTime ShipmentDate { get { return shipmentDate; } set { shipmentDate = value; } }
        public Employee RegisteredEmployee { get { return registeredEmp; } set { registeredEmp = value; } }
        public ProductState State { get { return state; } set { state = value; } }
        public string Barcode 
        {
            get { return barcode; }
            set 
            {
                bool success = Regex.IsMatch(value, @"\d{13}");
                if (!success)
                {
                    throw new BarcodeException("Barcode must contain only 13 digits");
                }
                else
                {
                    this.barcode = value;
                }
            } 
        }

        public Product(int id, string model, string brandName, float price, string description, double weight, double height, double width, double depth, string category, int aisleNumber, int qtyWh, int qtySh, DateTime shipmentDate, Employee registeredEmp, ProductState state, string name, string barcode)
        {
            this.id = id;
            this.model = model;
            this.brandName = brandName;
            this.price = price;
            this.description = description;
            this.weight = weight;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.category = category;
            this.aisleNumber = aisleNumber;
            this.shipmentDate = shipmentDate;
            this.qtyWh = qtyWh;
            this.qtySh = qtySh;
            this.registeredEmp = registeredEmp;
            this.state = state;
            this.name = name;
            this.Barcode = barcode;
        }

        public Product(string model, string brandName, float price, string description, double weight, double height, double width, double depth, string category, int aisleNumber, int qtyWh, int qtySh, DateTime shipmentDate, Employee registeredEmp, ProductState state, string name, string barcode)
        {
            this.id = idHelper;
            idHelper++;
            this.model = model;
            this.brandName = brandName;
            this.price = price;
            this.description = description;
            this.weight = weight;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.category = category;
            this.aisleNumber = aisleNumber;
            this.shipmentDate = shipmentDate;
            this.qtyWh = qtyWh;
            this.qtySh = qtySh;
            this.registeredEmp = registeredEmp;
            this.state = state;
            this.name = name;
            this.Barcode = barcode;
        }

        public override string ToString()
        {
            return $"Id: {id} Model: {model} BrandName: {brandName} Price: {price} Description: {description} Weight: {weight} Height: {height} Width: {width} Depth: {depth} Category: {category} AisleNumber: {aisleNumber} ShipmentDate: {shipmentDate} RegisterdEmployee: {RegisteredEmployee.FirstName + RegisteredEmployee.LastName} State: {state} Name: {name} Barcode: {barcode}";
        }
    }
}
