using System.Collections.Generic;

namespace Core
{
	/// <summary>
	/// Класс параметров модели
	/// </summary>
	public class Parameters
	{
		/// <summary>
		/// Словарь параметров модели
		/// </summary>
		private readonly Dictionary<ParameterType, int> _parameters
			= new Dictionary<ParameterType, int>
			{
				{ParameterType.DresserLength, 1000},
				{ParameterType.BoxWidth, 400},
				{ParameterType.DresserHeight, 700},
				{ParameterType.DresserWidth, 450},
				{ParameterType.BoxNumber, 3},
				{ParameterType.DresserShape, 0},
			};

		/// <summary>
		/// Возвращает существование ошибки
		/// </summary>
		public bool HasError { get; private set; }

		/// <summary>
		/// Сообщение об ошибке
		/// </summary>
		public string ErrorString { get; private set; }

		/// <summary>
		/// Возвращает параметр по перечислению <see cref="ParameterType"/>
		/// </summary>
		/// <param name="parameterType">Тип параметра</param>
		/// <returns>Выбранный параметр</returns>
		public int GetValueParameter(ParameterType parameterType)
		{
			return _parameters[parameterType];
		}

		/// <summary>
		/// Устанавливает значение выбранному параметру 
		/// </summary>
		/// <param name="parameterType">Тип параметра</param>
		/// <param name="value">Значение</param>
		public void SetValueParameter(ParameterType parameterType, int value)
		{
			_parameters[parameterType] = value;
			if (parameterType != ParameterType.BoxWidth &&
			    parameterType != ParameterType.DresserWidth)
			{
				return;
			}

			const int differenceWidth = 50;
			HasError = _parameters[ParameterType.DresserWidth] 
				- _parameters[ParameterType.BoxWidth] < differenceWidth;
			ErrorString = HasError
				? "Разница между шириной комода и " +
				  $"шириной ящика меньше {differenceWidth} мм!"
				: string.Empty;
		}
	}
}