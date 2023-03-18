using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class ValidationService
    {
        private readonly ErrorProvider _errorProvider;

        public ValidationService(ErrorProvider errorProvider)
        {
            this._errorProvider = errorProvider;
        }

        public void ValidateEmpty(object sender, CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtBox.Text))
            {
                e.Cancel = true;                
                _errorProvider.SetError(txtBox, "Pole je povinné");
            }
            else
            {
                e.Cancel = false;
                _errorProvider.SetError(txtBox, string.Empty);
            }
        }

        public void ValidatePostalCode(object sender, CancelEventArgs e)
        {
            string error = "Směrovací číslo musí mít formát \"000 00\"";
            string pattern = @"^\d{3} \d{2}$";

            Validate(pattern, error, sender, e);
        }

        public void ValidateTIN(object sender, CancelEventArgs e)
        {
            string error = "Identifikační číslo musí mít formát \"000000\"";
            string pattern = @"^\d{6}$";

            Validate(pattern, error, sender, e);
        }

        public void ValidateMeasureValue(object sender, CancelEventArgs e)
        {
            string error = "Hodnota musí být celé číslo nebo desetinné";
            string pattern = @"^[\d\.]+$";

            Validate(pattern, error, sender, e);
        }

        private void Validate(string pattern, string errorMessage, object sender, CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(txtBox.Text))
            {
                e.Cancel = true;                
                _errorProvider.SetError(txtBox, errorMessage);
            }
            else
            {
                e.Cancel = false;
                _errorProvider.SetError(txtBox, string.Empty);
            }
        }

        public static bool IsProtocolValid(ProtocolModel model)
        {
            string measurementValuePattern = @"^[\d\.]+$";
            string tinPattern = @"^\d{6}$";
            string postalCodepattern = @"^\d{3} \d{2}$";

            Regex tinRegex = new Regex(tinPattern);
            Regex postalCodeRegex = new Regex(postalCodepattern);
            Regex measurementValueRegex = new Regex(measurementValuePattern);

            bool isAnyDeviceValueEmpty = IsAnyValueEmpty(model.Device.Manufacturer, model.Device.Model, model.Device.SerialCode);
            bool isAnyCustomerValueEmpty = IsAnyValueEmpty(model.Customer.Name, model.Customer.Address, model.Customer.PostalCode, model.Customer.TIN);
            bool isAnyInfoValueEmpty = IsAnyValueEmpty(model.Info.MeasurementDate.ToString(), model.Info.ProtocolNumber);

            bool isAnyMeasurementValueEmpty = model.Measurements.Any(x => IsAnyValueEmpty(x.Unit, x.Parameter, x.Value, x.SuitsText));

            if (isAnyDeviceValueEmpty || isAnyCustomerValueEmpty || isAnyInfoValueEmpty || isAnyMeasurementValueEmpty)
            {
                return false;
            }

            bool areMeasurementValuesValid = model.Measurements.Any(x => measurementValueRegex.IsMatch(x.Value));
            bool isTinValid = tinRegex.IsMatch(model.Customer.TIN);
            bool isPostalCodeValid = postalCodeRegex.IsMatch(model.Customer.PostalCode);

            if (!areMeasurementValuesValid || !isTinValid || !isPostalCodeValid)
            {
                return false;
            }

            return true;
        }

        private static bool IsAnyValueEmpty(params string[] values)
        {
            return values.Any(x => string.IsNullOrEmpty(x));
        }
    }
}