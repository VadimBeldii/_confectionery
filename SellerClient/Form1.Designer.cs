﻿
namespace SellerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.CountTB = new System.Windows.Forms.TextBox();
            this.ShowOrderButton = new System.Windows.Forms.Button();
            this.SendOrderButton = new System.Windows.Forms.Button();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.ProductsLV = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddOrderTab = new System.Windows.Forms.TabPage();
            this.AcceptOrderTab = new System.Windows.Forms.TabPage();
            this.OrderItemsLV = new System.Windows.Forms.ListView();
            this.OrderExecutedBtn = new System.Windows.Forms.Button();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.UpdateFormBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddOrderTab.SuspendLayout();
            this.AcceptOrderTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.Location = new System.Drawing.Point(5, 2);
            this.CategoriesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(196, 320);
            this.CategoriesPanel.TabIndex = 0;
            // 
            // CountTB
            // 
            this.CountTB.Location = new System.Drawing.Point(603, 4);
            this.CountTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CountTB.Name = "CountTB";
            this.CountTB.Size = new System.Drawing.Size(44, 23);
            this.CountTB.TabIndex = 3;
            // 
            // ShowOrderButton
            // 
            this.ShowOrderButton.Location = new System.Drawing.Point(512, 272);
            this.ShowOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowOrderButton.Name = "ShowOrderButton";
            this.ShowOrderButton.Size = new System.Drawing.Size(135, 22);
            this.ShowOrderButton.TabIndex = 4;
            this.ShowOrderButton.Text = "Просмотреть заказ";
            this.ShowOrderButton.UseVisualStyleBackColor = true;
            this.ShowOrderButton.Click += new System.EventHandler(this.ShowOrderButton_Click);
            // 
            // SendOrderButton
            // 
            this.SendOrderButton.Location = new System.Drawing.Point(512, 298);
            this.SendOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendOrderButton.Name = "SendOrderButton";
            this.SendOrderButton.Size = new System.Drawing.Size(135, 22);
            this.SendOrderButton.TabIndex = 5;
            this.SendOrderButton.Text = "Отправить";
            this.SendOrderButton.UseVisualStyleBackColor = true;
            this.SendOrderButton.Click += new System.EventHandler(this.SendOrderButton_Click);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(515, 4);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(82, 22);
            this.AddProductBtn.TabIndex = 6;
            this.AddProductBtn.Text = "Добавить";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.Location = new System.Drawing.Point(515, 31);
            this.RemoveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(135, 22);
            this.RemoveProduct.TabIndex = 7;
            this.RemoveProduct.Text = "Удалить";
            this.RemoveProduct.UseVisualStyleBackColor = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // ProductsLV
            // 
            this.ProductsLV.HideSelection = false;
            this.ProductsLV.Location = new System.Drawing.Point(207, 2);
            this.ProductsLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsLV.Name = "ProductsLV";
            this.ProductsLV.Size = new System.Drawing.Size(302, 320);
            this.ProductsLV.TabIndex = 8;
            this.ProductsLV.UseCompatibleStateImageBehavior = false;
            this.ProductsLV.View = System.Windows.Forms.View.Details;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddOrderTab);
            this.tabControl1.Controls.Add(this.AcceptOrderTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 355);
            this.tabControl1.TabIndex = 9;
            // 
            // AddOrderTab
            // 
            this.AddOrderTab.Controls.Add(this.ProductsLV);
            this.AddOrderTab.Controls.Add(this.SendOrderButton);
            this.AddOrderTab.Controls.Add(this.RemoveProduct);
            this.AddOrderTab.Controls.Add(this.ShowOrderButton);
            this.AddOrderTab.Controls.Add(this.CategoriesPanel);
            this.AddOrderTab.Controls.Add(this.AddProductBtn);
            this.AddOrderTab.Controls.Add(this.CountTB);
            this.AddOrderTab.Location = new System.Drawing.Point(4, 24);
            this.AddOrderTab.Name = "AddOrderTab";
            this.AddOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrderTab.Size = new System.Drawing.Size(655, 327);
            this.AddOrderTab.TabIndex = 0;
            this.AddOrderTab.Text = "Создать заказ";
            this.AddOrderTab.UseVisualStyleBackColor = true;
            // 
            // AcceptOrderTab
            // 
            this.AcceptOrderTab.Controls.Add(this.OrderItemsLV);
            this.AcceptOrderTab.Controls.Add(this.OrderExecutedBtn);
            this.AcceptOrderTab.Controls.Add(this.OrdersPanel);
            this.AcceptOrderTab.Location = new System.Drawing.Point(4, 24);
            this.AcceptOrderTab.Name = "AcceptOrderTab";
            this.AcceptOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.AcceptOrderTab.Size = new System.Drawing.Size(655, 327);
            this.AcceptOrderTab.TabIndex = 1;
            this.AcceptOrderTab.Text = "Выполнить заказ";
            this.AcceptOrderTab.UseVisualStyleBackColor = true;
            // 
            // OrderItemsLV
            // 
            this.OrderItemsLV.HideSelection = false;
            this.OrderItemsLV.Location = new System.Drawing.Point(220, 4);
            this.OrderItemsLV.Name = "OrderItemsLV";
            this.OrderItemsLV.Size = new System.Drawing.Size(419, 288);
            this.OrderItemsLV.TabIndex = 3;
            this.OrderItemsLV.UseCompatibleStateImageBehavior = false;
            this.OrderItemsLV.View = System.Windows.Forms.View.Details;
            // 
            // OrderExecutedBtn
            // 
            this.OrderExecutedBtn.Location = new System.Drawing.Point(520, 298);
            this.OrderExecutedBtn.Name = "OrderExecutedBtn";
            this.OrderExecutedBtn.Size = new System.Drawing.Size(119, 23);
            this.OrderExecutedBtn.TabIndex = 2;
            this.OrderExecutedBtn.Text = "Заказ выполнен";
            this.OrderExecutedBtn.UseVisualStyleBackColor = true;
            this.OrderExecutedBtn.Click += new System.EventHandler(this.OrderExecutedBtn_Click);
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Location = new System.Drawing.Point(5, 3);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(208, 318);
            this.OrdersPanel.TabIndex = 0;
            // 
            // UpdateFormBtn
            // 
            this.UpdateFormBtn.Location = new System.Drawing.Point(3, 0);
            this.UpdateFormBtn.Name = "UpdateFormBtn";
            this.UpdateFormBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateFormBtn.TabIndex = 10;
            this.UpdateFormBtn.Text = "Обновить";
            this.UpdateFormBtn.UseVisualStyleBackColor = true;
            this.UpdateFormBtn.Click += new System.EventHandler(this.UpdateFormBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.UpdateFormBtn);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Confectionery";
            this.tabControl1.ResumeLayout(false);
            this.AddOrderTab.ResumeLayout(false);
            this.AddOrderTab.PerformLayout();
            this.AcceptOrderTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.TextBox CountTB;
        private System.Windows.Forms.Button ShowOrderButton;
        private System.Windows.Forms.Button SendOrderButton;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.ListView ProductsLV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddOrderTab;
        private System.Windows.Forms.TabPage AcceptOrderTab;
        private System.Windows.Forms.Button UpdateFormBtn;
        private System.Windows.Forms.Button OrderExecutedBtn;
        private System.Windows.Forms.Panel OrdersPanel;
        private System.Windows.Forms.ListView OrderItemsLV;
    }
}

