using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class FormLaundrySystem : Form
    {
        readonly LaundrySystem lms = new LaundrySystem();

        public FormLaundrySystem()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            foreach(OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                ComboBoxOwnerOrderStatus.Items.Add(status.ToString());
            }

            foreach (Task todo in Enum.GetValues(typeof(Task)))
            {
                ComboBoxShirtTask.Items.Add(todo.ToString());
                ComboBoxPantTask.Items.Add(todo.ToString());
                ComboBoxSuitTask.Items.Add(todo.ToString());
                ComboBoxBedSheetTask.Items.Add(todo.ToString());
            }
        }

        private void ClearOrderDetail()
        {
            LabelDetailStatusCur.Text = "";
            LabelDetailAmountCur.Text = "";
            LabelDetailOrdererName.Text = "";
            LabelDetailOrdererAddress.Text = "";

            ListBoxOrderDetails.Items.Clear();
            string heading = "Type\tQuantity\tTo Do\t Amount";
            string line = " _________________________________";
            ListBoxOrderDetails.Items.Add(heading);
            ListBoxOrderDetails.Items.Add(line);
        }

        private void UpdateOrderDetail(Order order)
        {
            ClearOrderDetail();
            LabelDetailStatusCur.Text = order.Status.ToString();
            LabelDetailAmountCur.Text = order.TotalAmount.ToString();
            LabelDetailOrdererName.Text = order.OrderBy.Name;
            LabelDetailOrdererAddress.Text = order.OrderBy.Address;
            foreach (OrderItem item in order.Items)
            {
                string row = $"{item.Type}\t{item.Quantity}\t{item.Todo}\t{item.Amount}";
                ListBoxOrderDetails.Items.Add(row);
            }
        }

        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TextBoxCreateUserId.Text);
                string name = TextBoxCreateUserName.Text;
                string address = TextBoxCreateUserAddress.Text;
                lms.CreateUser(id, name, address);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private OrderItem OrderShirt()
        {
            OrderItem item = null;
            string qtyStr = TextBoxPlaceOrderShirtQt.Text;
            string todoStr = ComboBoxShirtTask.Text;
            if (int.TryParse(qtyStr, out int qty) && Enum.TryParse(todoStr, out Task todo))
            {
                item = new OrderItem(ClothType.Shirt, qty, todo);
            }
            return item;
        }

        private OrderItem OrderPant()
        {
            OrderItem item = null;
            string qtyStr = TextBoxPlaceOrderPantQt.Text;
            string todoStr = ComboBoxPantTask.Text;
            if (int.TryParse(qtyStr, out int qty) && Enum.TryParse(todoStr, out Task todo))
            {
                item = new OrderItem(ClothType.Pant, qty, todo);
            }
            return item;
        }

        private OrderItem OrderSuit()
        {
            OrderItem item = null;
            string qtyStr = TextBoxPlaceOrderSuitQt.Text;
            string todoStr = ComboBoxSuitTask.Text;
            if (int.TryParse(qtyStr, out int qty) && Enum.TryParse(todoStr, out Task todo))
            {
                item = new OrderItem(ClothType.Suit, qty, todo);
            }
            return item;
        }

        private OrderItem OrderBedSheet()
        {
            OrderItem item = null;
            string qtyStr = TextBoxPlaceOrderBedSheetQt.Text;
            string todoStr = ComboBoxBedSheetTask.Text;
            if (int.TryParse(qtyStr, out int qty) && Enum.TryParse(todoStr, out Task todo))
            {
                item = new OrderItem(ClothType.BedSheet, qty, todo);
            }
            return item;
        }

        private List<OrderItem> GetOrderList()
        {
            List<OrderItem> items = new List<OrderItem>();

            OrderItem item = OrderShirt();
            if (item != null) items.Add(item);

            item = OrderPant();
            if (item != null) items.Add(item);

            item = OrderSuit();
            if (item != null) items.Add(item);

            item = OrderBedSheet();
            if (item != null) items.Add(item);

            return items;
        }
        
        private void ButtonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = Convert.ToInt32(TextBoxPlaceOrderUserId.Text);
                List<OrderItem> items = GetOrderList();
                if (items.Count == 0) throw new InvalidOrderItemsException();
                int orderId = lms.PlaceOrder(userid, items);
                MessageBox.Show($"Placed Order Successfilly. Order ID: {orderId}");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonDetailOrderSee_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(TextBoxDetailOrderId.Text);
                Order order = lms.FindOrder(orderId);
                UpdateOrderDetail(order);
                if (order.Status == OrderStatus.Processing) MessageBox.Show($"Estimated Delivery Date: {order.Estimated}");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void ButtonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(TextBoxOwnerOrderId.Text);
                Order order = lms.FindOrder(orderId);
                string status = ComboBoxOwnerOrderStatus.Text;
                lms.Owner.SetStatus(order, (OrderStatus)Enum.Parse(typeof(OrderStatus), status));
                LabelOwnerCurBalance.Text = lms.Owner.Balance.ToString();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
