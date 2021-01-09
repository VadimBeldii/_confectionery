﻿using Confectionery.BLL.DTOs;
using Confectionery.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SellerClient
{
    //test
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            apiWrapper = new ApiWrapper();
        }

        private readonly IApiWrapper apiWrapper;

        private ICollection<CategoryDTO> categories;
        private CategoryDTO currentCategory;
        private ICollection<ProductDTO> products;
        private Order newOrder = new Order { OrderItems = new List<OrderItem>() };

        private ICollection<Order> orders;
        private Order currentOrder;

        #region create order
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            var item = newOrder.OrderItems.SingleOrDefault(o => o.ProductId == currentCategory.Products[ProductsLV.SelectedIndices[0]].Id);


            if (uint.TryParse(CountTB.Text, out uint count)
                && count <= currentCategory.Products[ProductsLV.SelectedIndices[0]].Count)
            {
                if (item == default(OrderItem))
                {
                    newOrder.OrderItems.Add(new OrderItem
                    {
                        Count = (int)count,
                        ProductId = currentCategory.Products[ProductsLV.SelectedIndices[0]].Id
                    });
                }
                else
                {
                    item.Count += (int)count;
                }
                currentCategory.Products[ProductsLV.SelectedIndices[0]].Count -= (int)count;
            }
            else
            {
                MessageBox.Show("Unable to order");
            }
            CountTB.Text = "1";
        }
        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            newOrder.OrderItems.Remove(
                newOrder.OrderItems.FirstOrDefault(o => o.ProductId == currentCategory.Products[ProductsLV.SelectedIndices[0]].Id));
        }
        private void SendOrderButton_Click(object sender, EventArgs e)
        {
            if (newOrder.OrderItems == null || newOrder.OrderItems.Count == 0)
            {
                return;
            }
            newOrder.Time = DateTime.Now;
            apiWrapper.SendOrder(newOrder);
            newOrder = new Order
            {
                OrderItems = new List<OrderItem>()
            };

            currentCategory = null;
            UpdateForm();
            UpdateProductList();
        }
        private void ShowOrderButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            decimal price = 0;

            if (newOrder.OrderItems != null || newOrder.OrderItems.Count != 0)
            {
                foreach (var i in newOrder.OrderItems)
                {
                    sb.Append($"{products.First(p => p.Id == i.ProductId).Name} ({i.Count} шт.) \n");
                    price += i.Count * products.First(p => p.Id == i.ProductId).Price;
                }
                sb.Append($"Total price: {price}");
            }

            var prompt = new Form()
            {
                Width = 500,
                Height = 500,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Текущий заказ: ",
                StartPosition = FormStartPosition.CenterScreen
            };
            var textLabel = new Label()
            {
                Left = 50,
                Top = 20,
                Width = 400,
                Height = 300,
                Text = sb.ToString()
            };
            var confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 400, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog();
        }
        #endregion

        #region utils
        private void UpdateProductList()
        {
            ProductsLV.Items.Clear();
            ProductsLV.Columns.Clear();
            if (currentCategory != null)
            {
                ProductsLV.Columns.Add("Name", "Название");
                ProductsLV.Columns.Add("Price", "Цена");
                ProductsLV.Columns.Add("Description", "Описание");
                ProductsLV.Columns.Add("Count", "Остаток на складе");
                foreach (var p in currentCategory.Products)
                {
                    var item = new ListViewItem(new[] { p.Name, p.Price.ToString(), p.Description, p.Count.ToString() });
                    ProductsLV.Items.Add(item);
                }
            }
        }
        private void UpdateOrderItemsList()
        {
            OrderItemsLV.Items.Clear();
            OrderItemsLV.Columns.Clear();
            if (currentOrder != null)
            {
                OrderItemsLV.Columns.Add("Name", "Название");
                OrderItemsLV.Columns.Add("Count", "Количество");
                foreach (var o in currentOrder.OrderItems)
                {
                    var item = new ListViewItem(new[] { products.First(p => p.Id == o.ProductId).Name, o.Count.ToString() });
                    OrderItemsLV.Items.Add(item);
                }
            }
        }
        private void UpdateForm()
        {
            CategoriesPanel.Controls.Clear();
            categories = apiWrapper.GetCategories();
            products = apiWrapper.GetProducts();
            foreach (var c in categories)
            {
                var btn = new Button { Text = c.Name };
                btn.Width = CategoriesPanel.Width;
                btn.Height = 50;
                btn.Top = CategoriesPanel.Controls.Count * 50;
                btn.Click += (sender, e) =>
                {
                    currentCategory = c;
                    UpdateProductList();
                };
                CategoriesPanel.Controls.Add(btn);
            }

            OrdersPanel.Controls.Clear();
            orders = apiWrapper.GetOrders();
            foreach (var o in orders)
            {
                var btn = new Button { Text = o.Time.ToString() };
                btn.Width = OrdersPanel.Width;
                btn.Height = 50;
                btn.Top = OrdersPanel.Controls.Count * 50;
                btn.Click += (sender, e) =>
                {
                    currentOrder = o;
                    UpdateOrderItemsList();
                };
                OrdersPanel.Controls.Add(btn);
            }
        }
        #endregion

        #region common
        private void UpdateFormBtn_Click(object sender, EventArgs e)
        {
            UpdateForm();
        }
        #endregion

        private void OrderExecutedBtn_Click(object sender, EventArgs e)
        {
            apiWrapper.MarkOrderAsExecuted(currentOrder);
            UpdateForm();
            currentOrder = null;
            UpdateOrderItemsList();
        }
    }
}
