using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MVP
{
    public partial class FormMVP : Form, IView
    {
    	
    	public FormMVP()
        {
            InitializeComponent();
        }

        #region Реализация IView

        public event EventHandler<EventArgs> SetCelsius;
        public event EventHandler<EventArgs> SetFarenheit;

        /// <summary>
        /// Вывод градусов Фаренгейта
        /// </summary>
        public void SetFarenheit_(double value)
        {
            _farenheitBox.Text = value.ToString("N2");
        }

        /// <summary>
        /// Вывод градусов Цельсия
        /// </summary>
        public void SetCelsius_(double value)
        {
            _celsiusBox.Text = value.ToString("N2");
        }

        /// <summary>
        /// Ввод нового значения градусов
        /// </summary>
        public double InputDegree
        {
            get { return Convert.ToDouble(_inputBox.Text); }
        }

        #endregion

        /// <summary>
        /// Обработка событий тоже примитивна, они просто пробрасываются
        /// в соответствующие события Presenter-а
        /// </summary>
        private void _celsiusButton_Click(object sender, EventArgs e)
        {
            if (SetCelsius != null)
                SetCelsius(this, EventArgs.Empty);
        }

        private void _farenheitButton_Click(object sender, EventArgs e)
        {
            if (SetFarenheit != null)
                SetFarenheit(this, EventArgs.Empty);
        }
    }
}
