﻿using System;
using System.Windows.Forms;
using PT_Camping.Model;
using PT_Camping.Properties;

namespace PT_Camping.Views.Forms
{
    /// <summary>
    /// This class is used to apply a reduction on a client bill
    /// 
    /// </summary>
    /// Authors : Valentine
    /// Since : 15/03/17
    public partial class ApplyReduction : Form
    {
        private int _reductionPercent;
        private int _fidelityReduction;
        private readonly Client _client;
        private int _totalReduction;


        public ApplyReduction(Client client)
        {
            InitializeComponent();
            _reductionPercent = 0;
            _fidelityReduction = 0;
            _totalReduction = 0;
            _client = client;
            CalculateFidelityPercent();
        }


        private void ReducButtonSelected(object sender, EventArgs e)
        {
            if (studentRadioButton.Checked)
                _reductionPercent = 5;
            else if (seniorRadioButton.Checked)
                _reductionPercent = 5;
            else if (familyRadioButton.Checked)
                _reductionPercent = 10;
            else if (groupRadioButton.Checked)
                _reductionPercent = 15;
        }


        private void CalculateFidelityPercent()
        {
            int nbYearsFidelity = DateTime.Now.Year - _client.Date_Inscription.Year;
            for (int i = 0; i < nbYearsFidelity; i++)
            {
                if(i == 0 % 5)
                {
                  _fidelityReduction += 2;
                }
            }
            percentageSeniorLabel.Text = _fidelityReduction + Resources.percent_symbol;
        }
        
        
        private void CalculateTotalReduction()
        {
            _totalReduction = _reductionPercent + _fidelityReduction;
        }

        private void ValidReducbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

  
}
