using InventoryTool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTool.Models;
using System.Windows.Forms;
using Data.Products;
using Data.Parts;

namespace InventoryTool.Presenters
{
    public class ProductPresenter
    {
        private IProductView _view;
        private IProductModel _model;
        private BindingSource _candidatePartsBindingSource;
        private BindingSource _partsAssociatedToProductBindingSource;
        private List<Part> _candidatePartsList;
        private HashSet<Part> _associatedPartsList = new HashSet<Part>();


        public event EventHandler RefreshMainView;
        public ProductPresenter(IProductView view, IProductModel model, IEnumerable<Part> partsList)
        {
            _partsAssociatedToProductBindingSource = new BindingSource();
            _candidatePartsBindingSource = new BindingSource()
            {
                DataSource = partsList
            };

            _view = view;
            _model = model;
            _candidatePartsList = partsList.ToList();

            _view.AddProduct += AddNewProduct;
            _view.ModifyProduct += ModifyProduct;
            _view.CancelAction += CancelAction;
            _view.AssociatePartToProduct += AssociatePartToProduct;
            _view.DeletePartFromProduct += DeletePartFromProduct;
            _view.Show();

            if (_view.SelectedProduct != null)
            {
                DisplayProductToModify();
            }

            LoadAssociatedPartsList();
            _view.SetCandidatePartsBindingSource(_candidatePartsBindingSource);
            _view.SetAssociatedPartsBindingSource(_partsAssociatedToProductBindingSource);
        }


        private void LoadAssociatedPartsList()
        {
            _partsAssociatedToProductBindingSource.DataSource = _associatedPartsList != null ? _associatedPartsList.ToList() : new List<Part>();
        }

        private void AssociatePartToProduct(object sender, EventArgs e)
        {
            if (_view.SelectedCandidatePartId == null)
            {
                MessageBox.Show("Cannot add part without a part selected");
                return;
            }

            var canParseId = long.TryParse(_view.SelectedCandidatePartId, out var selectedPartId);

            if (!canParseId)
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            var selectedPart = _candidatePartsList.Find(o => o.Id == selectedPartId);

            if (_associatedPartsList == null)
            {
                _associatedPartsList = new HashSet<Part> { selectedPart };
                LoadAssociatedPartsList();
            }
            else
            {
                var notDuplicate = _associatedPartsList.Add(selectedPart);

                if (!notDuplicate)
                {
                    MessageBox.Show("Cannot add dublicate parts");
                    return;
                }

                LoadAssociatedPartsList();
            }
        }

        private void DeletePartFromProduct(object sender, EventArgs e)
        {
            if (_associatedPartsList == null)
            {
                MessageBox.Show("There are no parts associated with this product");
                return;
            }

            if (_view.SelectedAssociatedPartId == null)
            {
                MessageBox.Show("Cannot delete part without a part selected");
                return;
            }

            var canParseId = long.TryParse(_view.SelectedAssociatedPartId, out var selectedPartId);

            if (!canParseId)
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            var selectedPart = _associatedPartsList.ToList().Find(o => o.Id == selectedPartId);
            _associatedPartsList.Remove(selectedPart);

            LoadAssociatedPartsList();
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            var result = _model.AddNewProduct(_view.ProductName, _view.Price, _view.InventoryCount, _view.MinimumInventoryCount, _view.MaximumInventoryCount, _associatedPartsList);
            MessageBox.Show(result.message);

            if (result.success)
            {
                RefreshMainView?.Invoke(this, EventArgs.Empty);
                _view.Close();
            }
        }

        private void DisplayProductToModify()
        {
            Product selectedProduct = _view.SelectedProduct;
            selectedProduct.Parts = _model.GetAssociatedParts(selectedProduct, _candidatePartsList);
            _associatedPartsList = selectedProduct.Parts;

            _view.Id = selectedProduct.Id.ToString();
            _view.ProductName = selectedProduct.Name;
            _view.InventoryCount = selectedProduct.InventoryCount.ToString();
            _view.MinimumInventoryCount = selectedProduct.MinimumInventoryCount.ToString();
            _view.MaximumInventoryCount = selectedProduct.MaximumInventoryCount.ToString();
            _view.Price = selectedProduct.Price.ToString(); ;
        }

        private void ModifyProduct(object sender, EventArgs e)
        {
            var result = _model.UpdateProduct(_view.Id, _view.ProductName, _view.Price, _view.InventoryCount, _view.MinimumInventoryCount, _view.MaximumInventoryCount, _associatedPartsList);
            MessageBox.Show(result.message);

            if (result.success)
            {
                RefreshMainView?.Invoke(this, EventArgs.Empty);
                _view.Close();
            }
        }

        private void CancelAction(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult userResult = MessageBox.Show($"Are you sure you want to cancel?", "Cancel", buttons);
            if (userResult == DialogResult.Yes)
            {
                _view.Close();
            }
        }

    }
}
