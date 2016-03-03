using System;

namespace Demo_MVP
{
    public interface IView
    {
        /// <summary>
        /// Вывод градусов Фаренгейта
        /// </summary>
        void SetFarenheit_(double value);

        /// <summary>
        /// Вывод градусов Цельсия
        /// </summary>
        void SetCelsius_(double value);

        /// <summary>
        /// Ввод нового значения градусов
        /// </summary>
        double InputDegree { get; }

        /// <summary>
        /// Событие ввода значения по Фаренгейту
        /// </summary>
        event EventHandler<EventArgs> SetFarenheit;

        /// <summary>
        /// Событие ввода значения по цельсию
        /// </summary>
        event EventHandler<EventArgs> SetCelsius;
    }
}
