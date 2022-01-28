using System;
using Core;
using NUnit.Framework;

namespace TestCore
{
	/// <summary>
	/// Класс тестирования <see cref="Core.Parameters"/>
	/// </summary>
	[TestFixture]
	public class ParametersTest
	{
		/// <summary>
		/// Возвращает новый экземпляр класса <see cref="Core.Parameters"/>
		/// </summary>
		private Parameters Parameters => new Parameters();

		[TestCase(ParameterType.DresserLength, 
			1000,
			TestName = "Проверка корректного получения" +
							 " значения параметра DresserLength.")]
		[TestCase(ParameterType.BoxWidth,
			400,
			TestName = "Проверка корректного получения" +
							 " значения параметра BoxWidth.")]
		[TestCase(ParameterType.DresserHeight,
			700,
			TestName = "Проверка корректного получения" +
							 " значения параметра DresserHeight.")]
		[TestCase(ParameterType.DresserWidth,
			450,
			TestName = "Проверка корректного получения" +
							 " значения параметра DresserWidth.")]
		[TestCase(ParameterType.BoxNumber,
			3,
			TestName = "Проверка корректного получения" +
							 " значения параметра BoxNumber.")]
		[TestCase(ParameterType.DresserShape,
			0,
			TestName = "Проверка корректного получения" +
							 " значения параметра DresserShape.")]
		public void TestGetValueParameter_CorrectValue(ParameterType parameterType, int expected)
		{
			var parameters = Parameters;

			var actual = parameters.GetValueParameter(parameterType);

			Assert.AreEqual(expected, actual, 
				"Не вернулось ожидаемое значение!");
		}

		[TestCase(ParameterType.DresserLength,
			3000,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра DresserLength.")]
		[TestCase(ParameterType.BoxWidth,
			500,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра BoxWidth.")]
		[TestCase(ParameterType.DresserHeight,
			900,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра DresserHeight.")]
		[TestCase(ParameterType.DresserWidth,
			500,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра DresserWidth.")]
		[TestCase(ParameterType.BoxNumber,
			4,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра BoxNumber.")]
		[TestCase(ParameterType.DresserShape,
			1,
			TestName = "Проверка корректного присвоения" +
			           " значения параметра DresserShape.")]
		public void TestSetValueParameter_CorrectValue(ParameterType parameterType, int value)
		{
			var parameters = Parameters;

			parameters.SetValueParameter(parameterType, value);

			var expected = value;

			var actual = parameters.GetValueParameter(parameterType);

			Assert.AreEqual(expected, actual,
				"Не присвоилось значение!");
		}

		[TestCase(ParameterType.BoxWidth,
			500,
			TestName = "Проверка некорректного присвоения" +
					   " значения параметра BoxWidth." +
					   "Должен флаг HasError быть в true и" +
					   " ErrorStrung не должна быть пуста")]
		public void TestSetValueParameter_IncorrectValue(ParameterType parameterType, int value)
		{
			var parameters = Parameters;

			parameters.SetValueParameter(parameterType, value);

			Assert.IsTrue(parameters.HasError, 
				"При некорректном значении не выдает ошибку");
			Assert.IsTrue(!string.IsNullOrEmpty(parameters.ErrorString),
				"Строка ошибки пуста");
		}

		[TestCase(TestName = "Проверка корректного присвоения" +
							 " значения параметра IsEnableShelves.")]
		public void TestSetIsEnableShelves_CorrectValue()
		{
			var parameters = Parameters;

			Assert.DoesNotThrow((() => parameters.IsEnableShelves = true),
				"Не присвоилось значение!");
		}

		[TestCase(TestName = "Проверка корректного получения" +
		                     " значения параметра IsEnableShelves.")]
		public void TestGetIsEnableShelves_CorrectValue()
		{
			var parameters = Parameters;
			var expected = true;

			parameters.IsEnableShelves = expected;

			var actual = parameters.IsEnableShelves;

			Assert.AreEqual(expected, actual,
				"Возвращаемое значение неверное!");
		}
	}
}
