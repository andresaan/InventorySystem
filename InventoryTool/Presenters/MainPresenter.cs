using InventoryTool.Models;
using InventoryTool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Parts;
using Data.EventArguments;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Data.Products;

namespace InventoryTool.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;
        private IMainModel _model;
        private BindingSource _partsBindingSource;
        private BindingSource _productsBindingSource;
        private IEnumerable<Part> _partsList;
        private IEnumerable<Product> _productsList;

        public MainPresenter(IMainView view, IMainModel model)
        {
            _partsBindingSource = new BindingSource();
            _productsBindingSource = new BindingSource();

            _view = view;
            _model = model;

            _view.ShowAddPartView += ShowAddPartView;
            _view.ShowModifyPartView += ShowModifyPartView;
            _view.DeletePart += DeletePart;

            _view.ShowAddProductView += ShowAddProductView;
            _view.ShowModifyProductView += ShowModifyProductView;
            _view.DeleteProduct += DeleteProduct;
            _view.ExitApplication += ExitApplication;

            _view.Show();

            LoadAllPartsList();
            _view.SetPartListBindingSource(_partsBindingSource);

            LoadAllProductsList();
            _view.SetProductListBindingSource(_productsBindingSource);
        }

        private void LoadAllProductsList()
        {
            _productsList = _model.GetAllProducts();
            _productsBindingSource.DataSource = _productsList;
        }

        private void ShowAddProductView(object sender, ShowAddOrModifyEventArguments e)
        {
            IProductView productView = new ProductView(e.FormType);
            var productModel = Program.ServiceProvider.GetRequiredService<IProductModel>();

            var productPresenter = new ProductPresenter(productView, productModel, _partsList);

            productPresenter.RefreshMainView += RefreshMainView;
        }

        private void ShowModifyProductView(object sender, ShowAddOrModifyEventArguments e)
        {
            if (_view.SelectedProductId == null)
            {
                MessageBox.Show("Cannot modify without a product selected");
                return;
            }
            
            var canParseId = long.TryParse(this._view.SelectedProductId, out var selectedProductId);

            if (!canParseId)
            {
                MessageBox.Show("Cannot find product to modify");
                return;
            }

            var selectedProduct = this._productsList.ToList().Find(o => o.Id == selectedProductId);

            IProductView productView = new ProductView(e.FormType, selectedProduct);
            var productModel = Program.ServiceProvider.GetRequiredService<IProductModel>();

            var partPresenter = new ProductPresenter(productView, productModel, _partsList);

            partPresenter.RefreshMainView += RefreshMainView;
        }

        private void DeleteProduct(object sender, EventArgs e)
        {
            if (_view.SelectedProductName == null)
            {
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult userResult = MessageBox.Show($"Are you sure you want to delete {_view.SelectedProductName}", "Delete Product", buttons);
            if (userResult == DialogResult.Yes)
            {
                var result = _model.DeleteProduct(_view.SelectedProductId);
                MessageBox.Show(result.message);

                LoadAllProductsList();
            }
        }

        private void LoadAllPartsList()
        {
            _partsList = _model.GetAllParts();
            _partsBindingSource.DataSource = _partsList;
        }

        private void ShowAddPartView(object sender, ShowAddOrModifyEventArguments e)
        {
            IPartView partView = new PartView(e.FormType);
            var partModel = Program.ServiceProvider.GetRequiredService<IPartModel>();

            var partPresenter = new PartPresenter(partView, partModel);

            partPresenter.RefreshMainView += RefreshMainView;
        }

        private void ShowModifyPartView(object sender, ShowAddOrModifyEventArguments e)
        {
            if (_view.SelectedPartId == null)
            {
                MessageBox.Show("Cannot modify without a product selected");
                return;
            }

            long.TryParse(this._view.SelectedPartId, out var selectedPartId);
            var selectedPart = this._partsList.ToList().Find(o => o.Id == selectedPartId);

            IPartView partView = new PartView(e.FormType, selectedPart);
            var partModel = Program.ServiceProvider.GetRequiredService<IPartModel>();

            var partPresenter = new PartPresenter(partView, partModel);

            partPresenter.RefreshMainView += RefreshMainView;
        }

        private void DeletePart(object sender, EventArgs e)
        {
            if (_view.SelectedPartName == null)
            {
                return;
            }

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult userResult = MessageBox.Show($"Are you sure you want to delete {_view.SelectedPartName}", "Delete Part", buttons);
            if (userResult == DialogResult.Yes)
            {
                var result = _model.DeletePart(_view.SelectedPartId);
                MessageBox.Show(result.message);

                LoadAllPartsList();
            }
        }
       
        private void RefreshMainView(object sender, EventArgs e)
        {
            LoadAllPartsList();
            LoadAllProductsList();
        }
        
        private void ExitApplication(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
