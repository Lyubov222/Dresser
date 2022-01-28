using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using KompasWrapper;

namespace DresserUI
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Параметры комода
        /// </summary>
	    private Parameters _parameters;

        /// <summary>
        /// Создатель комода
        /// </summary>
        private DresserBuilder _dresserBuilder;

        /// <summary>
        /// Словарь соотношения <see cref="NumericUpDown"/> и <see cref="ParameterType"/>
        /// </summary>
        private readonly Dictionary<NumericUpDown, ParameterType> _parameterTypes;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {  
            InitializeComponent();
            _dresserBuilder = new DresserBuilder();
            _parameters = new Parameters();
            _parameterTypes = new Dictionary<NumericUpDown, ParameterType>
            {
	            {DresserLengthNumericUpDown, ParameterType.DresserLength},
	            {BoxWidthNumericUpDown, ParameterType.BoxWidth},
	            {DresserHeightNumericUpDown, ParameterType.DresserHeight},
	            {DresserWidthNumericUpDown, ParameterType.DresserWidth},
	            {BoxNumberNumericUpDown, ParameterType.BoxNumber},
            };

            SetStartValue();
        }

        /// <summary>
        /// Устанавливает начальные значения для NumericUpDown
        /// </summary>
        private void SetStartValue()
        {
	        DresserLengthNumericUpDown.Value = 
		        _parameters.GetValueParameter(ParameterType.DresserLength);
	        BoxWidthNumericUpDown.Value = 
		        _parameters.GetValueParameter(ParameterType.BoxWidth);
	        DresserHeightNumericUpDown.Value = 
		        _parameters.GetValueParameter(ParameterType.DresserHeight);
	        DresserWidthNumericUpDown.Value = 
		        _parameters.GetValueParameter(ParameterType.DresserWidth);
	        BoxNumberNumericUpDown.Value = 
		        _parameters.GetValueParameter(ParameterType.BoxNumber);
	        DresserShapeComboBox.SelectedIndex = 
		        _parameters.GetValueParameter(ParameterType.DresserShape);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Открыть чертеж"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenDrawing_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing();  
            drawing.Show();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "Построить модель"
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBuild_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
	            "Вы уверены что хотите построить модель с данными значениями?", 
	            "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
	            if (!_parameters.HasError)
	            {
		            _dresserBuilder.Build(_parameters);
	            }
	            else
	            {
		            MessageBox.Show(_parameters.ErrorString,
			            "Ошибка", MessageBoxButtons.OK,
			            MessageBoxIcon.Error);
	            }
            }
        }

        /// <summary>
        /// Обработчик события нажатия на выбор типа комода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DresserShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dressCloserTypeCombobox = (ComboBox)sender;
            _parameters.SetValueParameter(ParameterType.DresserShape,
	            dressCloserTypeCombobox.SelectedIndex);
        }

        /// <summary>
        /// Обработчик события нажатия на изменение значения у контрола NumericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
	        var numericUpDown = (NumericUpDown) sender;
            _parameters.SetValueParameter(_parameterTypes[numericUpDown], (int)numericUpDown.Value);
            if (_parameters.HasError)
            {
	            BoxWidthNumericUpDown.BackColor = Color.PaleVioletRed;
	            DresserWidthNumericUpDown.BackColor = Color.PaleVioletRed;
            }
            else
            {
	            BoxWidthNumericUpDown.BackColor = Color.White;
	            DresserWidthNumericUpDown.BackColor = Color.White;
            }

            ErrorTableLayoutPanel.Visible = _parameters.HasError;
            ErrorLabel.Text = _parameters.ErrorString;
        }

        /// <summary>
        /// Обработчик события переключения чекбокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void IsEnableShelvesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			_parameters.IsEnableShelves = IsEnableShelvesCheckBox.Checked;
		}
	}
}
