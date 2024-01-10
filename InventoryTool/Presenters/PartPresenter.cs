using InventoryTool.Models;
using InventoryTool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Parts;

namespace InventoryTool.Presenters
{
    public class PartPresenter
    {
        IPartView _view;
        IPartModel _model;

        public event EventHandler RefreshMainView;

        public PartPresenter(IPartView view, IPartModel model)
        {
            _model = model;
            _view = view;

            _view.AddPart += AddNewPart;
            _view.ModifyPart += ModifyPart;
            _view.CancelAction += CancelAction;

            if (_view.SelectedPart != null)
            {
                DisplayPartToModify();
            }

           _view.Show();
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

        private void DisplayPartToModify()
        {
            var selectedPart = _view.SelectedPart;

            _view.Id = selectedPart.Id.ToString();
            _view.PartName = selectedPart.Name;
            _view.InventoryCount = selectedPart.InventoryCount.ToString();
            _view.MinimumInventoryCount = selectedPart.MinimumInventoryCount.ToString();
            _view.MaximumInventoryCount = selectedPart.MaximumInventoryCount.ToString();
            _view.Price = selectedPart.Price.ToString(); ;

            if (_view.SelectedPart is OutsourcedPart)
            {
                _view.IsOutsourced = true;
                _view.CompanyName = (selectedPart as OutsourcedPart).CompanyName;
            }

            if (_view.SelectedPart is InHousePart)
            {
                _view.IsInHouse = true;
                _view.MachineId = (selectedPart as InHousePart).MachineId.ToString();
            }
        }

        private void ModifyPart(object sender, EventArgs e)
        {
            var result = _model.UpdatePart(_view.Id, _view.PartName, _view.Price, _view.InventoryCount, _view.MinimumInventoryCount, _view.MaximumInventoryCount, _view.CompanyName, _view.MachineId, _view.IsInHouse, _view.IsOutsourced);
            MessageBox.Show(result.message);

            if (result.success)
            {
                RefreshMainView?.Invoke(this, EventArgs.Empty);
                _view.Close();
            }
        }

        private void AddNewPart(object sender, EventArgs e)
        {
            var result = _model.AddNewPart(_view.PartName, _view.Price, _view.InventoryCount, _view.MinimumInventoryCount, _view.MaximumInventoryCount, _view.CompanyName, _view.MachineId, _view.IsInHouse, _view.IsOutsourced);
            MessageBox.Show(result.message);

            if (result.success)
            {
                RefreshMainView?.Invoke(this, EventArgs.Empty);
                _view.Close();
            }
        }
    }
}
