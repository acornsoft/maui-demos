#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using core = Syncfusion.Maui.Core;

namespace SampleBrowser.Maui.TextInputLayout.SfTextInputLayout;

public partial class PaymentPageMobile : SampleView
{
	public PaymentPageMobile()
	{
		InitializeComponent();
        PayNameField.InputViewPadding= new Thickness(0,8,0,8);
        CardNumberField.InputViewPadding= new Thickness(0, 8, 0, 8);
        CardNumberField1.InputViewPadding= new Thickness(0, 8, 0, 8);
        CardNumberField2.InputViewPadding= new Thickness(0, 8, 0, 8);
        CardNumberField3.InputViewPadding= new Thickness(0, 8, 0, 8);
        CVVField.InputViewPadding= new Thickness(0, 8, 0, 8);
        MonthField.InputViewPadding= new Thickness(0, 8, 0, 8);
        YearField.InputViewPadding= new Thickness(0, 8, 0, 8);
    }
    private void SubmitButton_Clicked(object sender, EventArgs e)
    {
        FieldNullCheck(PayNameField);
        FieldNullCheck(CardNumberField);
        FieldNullCheck(CardNumberField1);
        FieldNullCheck(CardNumberField2);
        FieldNullCheck(CardNumberField3);
        FieldNullCheck(CVVField);
        FieldNullCheck(MonthField);
        FieldNullCheck(YearField);
        ValidateCardNumber();
    }

    private void FieldNullCheck(core.SfTextInputLayout inputLayout)
    {
        if (string.IsNullOrEmpty(inputLayout.Text))
            inputLayout.HasError = true;
    }

    private void ValidateCardNumber()
    {
        if (CardNumberField.Text == null || CardNumberField.Text.Count() != 4 || !double.TryParse(CardNumberField.Text, out double result))
        {
            CardNumberField.HasError = true;
        }

        if (CardNumberField1.Text == null || CardNumberField1.Text.Count() != 4 || !double.TryParse(CardNumberField1.Text, out result))
        {
            CardNumberField1.HasError = true;
        }

        if (CardNumberField2.Text == null || CardNumberField2.Text.Count() != 4 || !double.TryParse(CardNumberField2.Text, out result))
        {
            CardNumberField2.HasError = true;
        }

        if (CardNumberField3.Text == null || CardNumberField3.Text.Count() != 4 || !double.TryParse(CardNumberField3.Text, out result))
        {
            CardNumberField3.HasError = true;
        }

        if (CVVField.Text == null || CVVField.Text.Count() != 3 || !double.TryParse(CVVField.Text, out result))
        {
            CVVField.HasError = true;
        }

    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue.Length == 4)
        {
            CardNumberField1.Focus();
        }
    }

    private void Entry2_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue.Length == 4)
        {
            CardNumberField2.Focus();
        }
    }

    private void Entry3_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue.Length == 4)
        {
            CardNumberField3.Focus();
        }
    }
}