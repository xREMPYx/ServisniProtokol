using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class CustomerService
    {
        private readonly MainForm _mainForm;

        private CustomerModel _model = new();
        public CustomerModel GetModel() => _model;

        public CustomerService(MainForm form)
        {
            _mainForm = form;
        }

        public void Edit()
        {
            CustomerForm form = new CustomerForm(_model);

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                _model = form.GetModel();

                _mainForm.Lbl_Customer_Address.Text = _model.Address;
                _mainForm.Lbl_Customer_Name.Text = _model.Name;
                _mainForm.Lbl_Customer_PostalCode.Text = _model.PostalCode;
                _mainForm.Lbl_Customer_TIN.Text = _model.TIN;
            }
        }
    }
}
