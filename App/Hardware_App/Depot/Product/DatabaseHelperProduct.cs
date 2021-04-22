using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DatabaseHelperProduct
    {
        MySqlConnection connection;

        public DatabaseHelperProduct()
        {
            string info = "Server = studmysql01.fhict.local; Uid = dbi426239; Database = dbi426239; Pwd = 1234;";
            connection = new MySqlConnection(info);
        }

        public int UpdateProduct(Product p)
        {
            int recordsChanged = 0;
            string sql = "UPDATE products SET model = @model, brandName = @brand, description = @desc, weight = @weight, height = @height, width = @width, depth = @depth, category = @category, aisleNumber=@aisleNumber, qtyWh = @qtyWh, qtySh = @qtysh, shipmentDate = @shipmentD, registerdEmpId = @eId, state = @state, name = @name, barcode = @barcode WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", p.Id);
                command.Parameters.AddWithValue("@model", p.Model);
                command.Parameters.AddWithValue("@brand", p.BrandName);
                command.Parameters.AddWithValue("@desc", p.Description);
                command.Parameters.AddWithValue("@weight", p.Weight);
                command.Parameters.AddWithValue("@height", p.Height);
                command.Parameters.AddWithValue("@width", p.Width);
                command.Parameters.AddWithValue("@depth", p.Depth);
                command.Parameters.AddWithValue("@category", p.Category);
                command.Parameters.AddWithValue("@aisleNumber", p.AisleNumber);
                command.Parameters.AddWithValue("@qtyWh", p.QuantityWarehouse);
                command.Parameters.AddWithValue("@qtysh", p.QuantityShelf);
                command.Parameters.AddWithValue("@shipmentD", p.ShipmentDate);
                command.Parameters.AddWithValue("@eId", p.RegisteredEmployee.Id);
                command.Parameters.AddWithValue("@state", Enum.GetName(typeof(ProductState), p.State));
                command.Parameters.AddWithValue("@name", p.Name);
                command.Parameters.AddWithValue("@barcode", p.Barcode);

                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public int AddProduct(Product product)
        {

            int recordsChanged = 0;

            string sql = "INSERT INTO `products`(`id`, `model`,`brandName`, `price`, `description`, `weight`, `height`, `width`, `depth`, `category`, `aisleNumber`, `qtyWh`, `qtySh`, `shipmentDate`, `registerdEmpId`, `state`, `name`, `barcode`) " +
           "VALUES (@id,@model,@brandName,@price,@description,@weight,@height,@width,@depth,@category,@aisleNumber,@qtyWh,@qtySh,@shipmentDate,@registerdEmpId,@state, @name, @barcode)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@model", product.Model);
                command.Parameters.AddWithValue("@brandName", product.BrandName);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@weight", product.Weight);
                command.Parameters.AddWithValue("@height", product.Height);
                command.Parameters.AddWithValue("@width", product.Width);
                command.Parameters.AddWithValue("@depth", product.Depth);
                command.Parameters.AddWithValue("@category", product.Category);
                command.Parameters.AddWithValue("@aisleNumber", product.AisleNumber);
                command.Parameters.AddWithValue("@qtyWh", product.QuantityWarehouse);
                command.Parameters.AddWithValue("@qtySh", product.QuantityShelf);
                command.Parameters.AddWithValue("@shipmentDate", product.ShipmentDate);
                command.Parameters.AddWithValue("@registerdEmpId", product.RegisteredEmployee.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@barcode", product.Barcode);
                command.Parameters.AddWithValue("@state", Enum.GetName(typeof(ProductState), product.State).ToString());

                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }

            return recordsChanged;
        }

        public List<Product> loadProducts(List<Employee> employees)
        {
            string sql = "SELECT * from products";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int id;
                string model;
                string brandName;
                float price;
                string description;
                double weight;
                double height;
                double width;
                double depth;
                string category;
                int aisleNumber;
                int qtyWh;
                int qtySh;
                DateTime shipmentDate;
                Employee registeredEmp;
                ProductState state;
                string name;
                string barcode;
                List<Product> products = new List<Product>();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                    model = reader["model"].ToString();
                    brandName = reader["brandName"].ToString();
                    price = Convert.ToSingle(reader["price"]);
                    description = reader["description"].ToString();
                    weight = Convert.ToDouble(reader["weight"]);
                    height = Convert.ToDouble(reader["height"]);
                    width = Convert.ToDouble(reader["width"]);
                    depth = Convert.ToDouble(reader["depth"]);
                    category = reader["category"].ToString();
                    aisleNumber = Convert.ToInt32(reader["aisleNumber"]);
                    qtyWh = Convert.ToInt32(reader["qtyWh"]);
                    qtySh = Convert.ToInt32(reader["qtySh"]);
                    shipmentDate = Convert.ToDateTime(reader["shipmentDate"]);
                    registeredEmp = ReturnEmployeeFromId(Convert.ToInt32(reader["registerdEmpId"]), employees);
                    state = ConvertStringToState(reader["state"].ToString());
                    name = reader["name"].ToString();
                    barcode = reader["barcode"].ToString();
                    products.Add(new Product(id, model, brandName, price, description, weight, height, width, depth, category, aisleNumber, qtyWh, qtySh, shipmentDate, registeredEmp, state, name, barcode));
                }
                return products;
            }
            finally { connection.Close(); }
        }

        public int RemoveProduct(Product p)
        {
            int recordsChanged = 0;
            string sql = "DELETE FROM products WHERE id=@pid;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@pid", p.Id);
                recordsChanged += command.ExecuteNonQuery();
            }
            catch { return 0; }
            finally
            {
                connection.Close();
            }
            return recordsChanged;
        }

        public void assignId()
        {
            string sql = "select count(*) as col1 from products";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                int startid = -1;


                while (reader.Read())
                {
                    startid = Convert.ToInt32(reader["col1"]);
                }
                Product.idHelper = startid + 1;
            }
            finally { connection.Close(); }
        }

        private Employee ReturnEmployeeFromId(int id, List<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == id)
                {
                    return e;
                }

            }
            return null;
        }

        private ProductState ConvertStringToState(string s)
        {
            switch (s)
            {
                case "AVAILABLE":
                    return ProductState.AVAILABLE;
                case "UNAVAILABLE":
                    return ProductState.UNAVAILABLE;
                default: return ProductState.UNAVAILABLE;
            }
        }
    }
}
