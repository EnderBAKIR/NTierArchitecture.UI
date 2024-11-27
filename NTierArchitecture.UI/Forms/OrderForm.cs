using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class OrderForm : Form
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly OrderDetailService _orderDetailService;
        private Customer _newCustomer;
        private Employee _newEmployee;
        public OrderForm()
        {
            InitializeComponent();
            _dbContext = new ApplicationDBContext();
            ProductRepository productRepository = new ProductRepository(_dbContext);
            OrderRepository orderRepository = new OrderRepository(_dbContext);
            OrderDetailRepository orderDetailRepository = new OrderDetailRepository(_dbContext);

            _productService = new ProductService(productRepository);
            _orderService = new OrderService(orderRepository);
            _orderDetailService = new OrderDetailService(orderDetailRepository);

            // burda yeni müşteri ve yeni çalışan oluşturdum
            _newCustomer = _dbContext.Customers.FirstOrDefault(c => c.CustomerName == "Ender"); // basit isim kontrolü yaptım burası ilerde kaldırılıp temize çekilebilir
            if (_newCustomer == null) // müşteri yoksa yeni eklensin
            {
                
                _newCustomer = new Customer
                {
                    CustomerName = "Ender",
                    Country = "Türkiye",
                    City = "İstanbul",
                    Phone = "1234567890",
                    IsActive = true
                };
                _dbContext.Customers.Add(_newCustomer);
                _dbContext.SaveChanges();
            }

            _newEmployee = _dbContext.Employees.FirstOrDefault(e => e.Name == "Mehmet");
            if (_newEmployee == null)// çalşıan yoksa yeni eklensin
            {
                
                _newEmployee = new Employee
                {
                    Name = "Mehmet",
                    SurName = "Çalışan",
                    Country = "Türkiye",
                    City = "İstanbul",
                    Phone = "0987654321",
                    IsActive = true


                };
                _dbContext.Employees.Add(_newEmployee);
                _dbContext.SaveChanges();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetAllProductsBySearchText(string.Empty);
            UpdateBasketSummary();
            LoadOrders();
        }
        private void UpdateBasketSummary() // form açıldıgında ve sepet ekle butonuna basıldığında fiyatı ve ürün adedini labellare yazdırcak metod.
        {
            
            double totalPrice = _cart.CardItems.Sum(item => item.UnitPrice * item.Quantity);
            int totalCount = _cart.CardItems.Sum(item => item.Quantity);
            lblBasketTotal.Text = $"Sepet Toplamı: {totalPrice:C2} TL";
            lblBasketCount.Text = $"Ürün Adedi: {totalCount}";
        }


        private void GetAllProductsBySearchText(string searhText)
        {
            if (!string.IsNullOrEmpty(searhText.ToLower()) && searhText.Length >= 3)
            {
                //Ürünleri filtreye göre getir:
                var productList = _productService.GetAll().Where(p => p.ProductName.ToLower().Contains(searhText.ToLower()));

                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = productList.ToList();
            }

            if (searhText.Length == 0)
            {
                lstProductList.ValueMember = "Id";
                lstProductList.DisplayMember = "ProductName";
                lstProductList.DataSource = _productService.GetAll().ToList();
            }
        }

        private Card _cart = new Card(); //sepeti global olarak oluşturuyorum ki aynı ürünü tekrar tekrar eklemek yerine adedini arttırmak için.
        private void btnAddBasket_Click(object sender, EventArgs e)
        {

            if (_selectedProduct != null)
            {
                var cartItem = new CardItem
                {
                    ProductID = _selectedProduct.Id,
                    ProductName = _selectedProduct.ProductName,
                    UnitPrice = _selectedProduct.UnitPrice,
                    Quantity = (int)nmrQuantity.Value
                };
                _cart.AddItem(cartItem);
                UpdateBasketList();
            }
            else
            {
                MessageBox.Show("Lütfen sepete eklemek için bir ürün seçin");
            }
        }


        private void UpdateBasketList() //önce listeyi temizleyip sonra sepeti güncelledik
        {
            lstBasket.Items.Clear();

            foreach (var item in _cart.CardItems)
            {
                lstBasket.Items.Add($"{item.ProductName} - {item.Quantity} Adet - Toplam: {item.UnitPrice * item.Quantity:C2}");// c2 burda türk lirası yazdırma kodu
            }

            UpdateBasketSummary();// form açıldıgında ve sepet ekle butonuna basıldığında fiyatı ve ürün adedini labellare yazdırcak metod.
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.Show();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
          
            if (_cart.CardItems.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş");
                return;
            }

            // Yeni bir sipariş oluştur
            var order = new Order
            {
                OrderDate = DateOnly.FromDateTime(DateTime.Now),  // Sipariş tarihi
                ShipAddress = "Deneme Adresi", // buraları manuel ekledim
                ShipCity = "İstanbul", 
                ShipCountry = "Türkiye", 
                Employee = _newEmployee,
                Customer = _newCustomer, 
                OrderDetails = new List<OrderDetail>()
            };

            foreach (var item in _cart.CardItems)
            {
                var orderDetail = new OrderDetail
                {
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Order = order
                };

                order.OrderDetails.Add(orderDetail);
            }

            _orderService.Create(order);

            _cart.CardItems.Clear();
            MessageBox.Show("Siparişiniz kaydedildi.");
            UpdateBasketList();
            UpdateBasketSummary();
            LoadOrders();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex != -1)
            {
                var selectedCartItem = _cart.CardItems[lstBasket.SelectedIndex];
                _cart.DeleteItem(selectedCartItem.CardItemID);

                UpdateBasketList();
            }
            else
            {
                MessageBox.Show("Ürün Seçmediniz");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetAllProductsBySearchText(txtSearch.Text);
        }


        private Product _selectedProduct; // burda seçili ürünü tek seferde bir değişkene atamak için yaptım kod fazlalığını önledim.
        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductList.SelectedValue != null)
            {
                string selectedProductId = lstProductList.SelectedValue.ToString();
                _selectedProduct = _productService.GetAll().FirstOrDefault(p => p.Id.ToString() == selectedProductId);

                if (_selectedProduct != null)
                {
                    txtUnitPrice.Text = _selectedProduct.UnitPrice.ToString("C2"); //c2 tl formatı ekliyor.
                }
            }
        }

        


        private void LoadOrders()// Form yüklendiğinde ve sipariş kaydedildiğinde Data grid viewi doldurmak için yazdım
        {
            var orders = _orderService.GetAll(); 

            // DataGridView'i sıfırlıyoruz
            dgwOrderList.Rows.Clear();
            foreach (var order in orders)
            {
                dgwOrderList.Rows.Add(
                    order.Id,
                    order.OrderDate,
                    order.ShipCountry,
                    order.ShipCity
                );
            }
        }

        private void dgwOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid selectedOrderId = (Guid)dgwOrderList.Rows[e.RowIndex].Cells["Id"].Value;

                //Order repositoryde Include metodu yazdım
                var selectedOrder = _orderService.GetOrderWithOrderDetails(selectedOrderId);

                if (selectedOrder != null)
                {
                    double totalAmount = selectedOrder.OrderDetails?.Sum(od => od.Quantity * od.UnitPrice) ?? 0;
                    lblTotal.Visible = true;
                    lblTotal.Text = $"Fatura Toplam Tutarı : {totalAmount:C2} + %20 KDV";

                    FillOrderDetails(selectedOrderId);
                }
            }
        }


        private void FillOrderDetails(Guid selectedOrderId)
        {
            
            var selectedOrder = _orderService.GetOrderWithOrderDetails(selectedOrderId);

            if (selectedOrder != null && selectedOrder.OrderDetails != null)
            {
                dgwOrderDetailList.Rows.Clear();
                foreach (var detail in selectedOrder.OrderDetails)
                {
                    dgwOrderDetailList.Rows.Add(
                        detail.Quantity,
                        detail.UnitPrice,
                        detail.Product?.ProductName,
                        selectedOrder.Employee?.Name,
                        selectedOrder.Customer?.CustomerName
                    );
                }
            }
        }
    }
}
