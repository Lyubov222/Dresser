using System;
using System.Collections.Generic;
using System.Drawing;
using Core;
using Kompas6API5;
using Kompas6Constants3D;

namespace KompasWrapper
{
	/// <summary>
	/// Класс построения комода
	/// </summary>
	public class DresserBuilder
	{
		/// <summary>
		/// Толщина стенок
		/// </summary>
		private const int WallsWidth = 10;

		/// <summary>
		/// Высота ножек
		/// </summary>
		private const int LegsHeight = 50;

		/// <summary>
		/// Ширина ножек
		/// </summary>
		private const int LegsWidth = 20;

		/// <summary>
		/// Первое расстояние от угла
		/// </summary>
		private const int LegsDistance1 = 28;

		/// <summary>
		/// Второе расстояние от угла
		/// </summary>
		private const int LegsDistance2 = 38;

		/// <summary>
		/// Координаты ножек комода
		/// </summary>
		private readonly List<Point> _legPoints = new List<Point>();

		/// <summary>
		/// Экземпляр класса работы с Компас 3D
		/// </summary>
		private readonly KompasWrapper _kompasWrapper;

		/// <summary>
		/// Длина ящиков
		/// </summary>
		private int _boxLength;

		/// <summary>
		/// Часть модели
		/// </summary>
		private ksPart _part;

		/// <summary>
		/// Параметры модели
		/// </summary>
		private Parameters _parameters;

		/// <summary>
		/// Конструктор
		/// </summary>
		public DresserBuilder()
		{
			_kompasWrapper = new KompasWrapper();
		}

		/// <summary>
		/// Построить модель
		/// </summary>
		/// <param name="parameters">Параметры</param>
		public void Build(Parameters parameters)
		{
			_legPoints.Clear();
			_parameters = parameters;
			_kompasWrapper.RunKompas();
			ksDocument3D document3D = _kompasWrapper.KompasObject.Document3D();
			document3D.Create();
			_part = document3D.GetPart((int)Part_Type.pTop_Part);

			CreateBody();
			CreateBoxHoles();
			CreateLegs();

			if (_parameters.IsEnableShelves)
			{
				CreateShelves();
			}
		}

		/// <summary>
		/// Создает полки
		/// </summary>
		private void CreateShelves()
		{
			const int shelvesDistance = 5;
			var dresserHeight = _parameters.GetValueParameter(
				ParameterType.DresserHeight);
			var boxNumber = _parameters.GetValueParameter(
				ParameterType.BoxNumber);
			var boxHeight =
				(dresserHeight - shelvesDistance * (boxNumber + 1))
				/ boxNumber;

			var halfWidth = _parameters.GetValueParameter(
				ParameterType.DresserWidth) / 2;
			ksEntity plane = _kompasWrapper.CreatePlaneOffsetXoz(_part, halfWidth);
			ksEntity sketch = _part.NewEntity((int)Obj3dType.o3d_sketch);
			ksSketchDefinition sketchDefinition = sketch.GetDefinition();
			sketchDefinition.SetPlane(plane);
			sketch.Create();

			// Входим в режим редактирования эскиза
			ksDocument2D document2D = sketchDefinition.BeginEdit();

			var point1 = new Point(-_boxLength / 2,
				-dresserHeight + shelvesDistance);
			var point2 = new Point(_boxLength / 2,
				point1.Y + boxHeight);
			const int radiusHole = 20;
			var yc = point1.Y + boxHeight / 2;
			for (int i = 0; i < boxNumber; i++)
			{
				CreateRectangle(point1, point2, document2D);
				document2D.ksEllipse(CreateEllipse(0, yc, 
					radiusHole, radiusHole, document2D));
				point1 = new Point(-_boxLength / 2,
					point2.Y + shelvesDistance);
				point2 = new Point(_boxLength / 2,
					point1.Y + boxHeight);
				yc = point1.Y + 
				                  boxHeight / 2;
			}

			sketchDefinition.EndEdit();

			const int widthShelf = 30;
			_kompasWrapper.BossExtrusion(_part, sketch, widthShelf, 
				Direction_Type.dtMiddlePlane);
		}

		/// <summary>
		/// Создать основную часть комода
		/// </summary>
		private void CreateBody()
		{
			ksEntity plane = _part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
			ksEntity sketch = _part.NewEntity((int)Obj3dType.o3d_sketch);
			ksSketchDefinition sketchDefinition = sketch.GetDefinition();
			sketchDefinition.SetPlane(plane);
			sketch.Create();

			// Входим в режим редактирования эскиза
			ksDocument2D document2D = sketchDefinition.BeginEdit();

			var dresserType = (DresserType)_parameters.GetValueParameter(
				ParameterType.DresserShape);
			switch (dresserType)
			{
				case DresserType.Rectangle:
				{
					CreateRectangleBody(document2D); 
					break;
				}
				case DresserType.Trapezoid:
				{
					CreateTrapezoidBody(document2D);
					break;
				}
				case DresserType.Ellipse:
				{
					CreateEllipseBody(document2D);
					break;
				}
				default:
				{
					throw new ArgumentOutOfRangeException();
				}
			}

			sketchDefinition.EndEdit();

			_kompasWrapper.BossExtrusion(_part, sketch, _parameters.GetValueParameter(
				ParameterType.DresserHeight), Direction_Type.dtNormal);
		}

		/// <summary>
		/// Сделать округлый комод
		/// </summary>
		private void CreateEllipseBody(ksDocument2D document2D)
		{
			var length = _parameters.GetValueParameter(
				ParameterType.DresserLength);
			var width = _parameters.GetValueParameter(
				ParameterType.DresserWidth);
			document2D.ksEllipse(CreateEllipse(0, 0,
				length / 2, width / 2, document2D));
			
			// Установка координат для ножек
			_legPoints.Add(new Point((int)(-0.25 * length),
				(int)(0.25 * width)));
			_legPoints.Add(new Point((int)(0.25 * length) - LegsWidth,
				(int)(0.25 * width)));
			_legPoints.Add(new Point((int)(-0.25 * length),
				(int)(-0.25 * width) + LegsWidth));
			_legPoints.Add(new Point((int)(0.25 * length) - LegsWidth,
				(int)(-0.25 * width) + LegsWidth));

			_boxLength = length / 3;
		}

		/// <summary>
		/// Сделать трапециевидный комод
		/// </summary>
		private void CreateTrapezoidBody(ksDocument2D document2D)
		{
			
			var halfLength = _parameters.GetValueParameter(
				ParameterType.DresserLength) / 2;
			var halfWidth = _parameters.GetValueParameter(
				ParameterType.DresserWidth) / 2;

			// Создаем 4 точки для трапеции
			var point1 = new Point(-halfLength, -halfWidth);
			var point2 = new Point(halfLength, -halfWidth);
			var point3 = new Point((int) (halfLength * 0.5), halfWidth);
			var point4 = new Point((int)(-halfLength * 0.5), halfWidth);

			document2D.ksLineSeg(point1.X, point1.Y,
				point2.X, point2.Y, 1);
			document2D.ksLineSeg(point2.X, point2.Y,
				point3.X, point3.Y, 1);
			document2D.ksLineSeg(point3.X, point3.Y,
				point4.X, point4.Y, 1);
			document2D.ksLineSeg(point4.X, point4.Y,
				point1.X, point1.Y, 1);

			// Установка координат для ножек
			_legPoints.Add(new Point(point1.X + LegsDistance1, 
				point1.Y + LegsDistance2));
			_legPoints.Add(new Point(
				point2.X - LegsDistance1 - LegsWidth,
				point2.Y + LegsDistance2));
			_legPoints.Add(new Point(point3.X - LegsDistance1,
				point3.Y - LegsDistance2 - LegsWidth));
			_legPoints.Add(new Point(
				point4.X + LegsDistance1 - LegsWidth,
				point3.Y - LegsDistance2 - LegsWidth));

			_boxLength = point3.X - point4.X - 2 * WallsWidth;
		}

		/// <summary>
		/// Сделать прямоугольный комод
		/// </summary>
		private void CreateRectangleBody(ksDocument2D document2D)
		{
			var halfLength = _parameters.GetValueParameter(
				ParameterType.DresserLength) / 2;
			var halfWidth = _parameters.GetValueParameter(
				ParameterType.DresserWidth) / 2;
			var point1 = new Point(-halfLength, -halfWidth);
			var point2 = new Point(halfLength, halfWidth);
			CreateRectangle(point1, point2, document2D);

			// Установка координат для ножек
			_legPoints.Add(new Point(point1.X + LegsDistance1,
				point1.Y + LegsDistance2));
			_legPoints.Add(new Point(point2.X - LegsDistance1 - LegsWidth,
				point1.Y + LegsDistance2));
			_legPoints.Add(new Point(point1.X + LegsDistance1,
				point2.Y - LegsDistance2 - LegsWidth));
			_legPoints.Add(new Point(point2.X - LegsDistance1 - LegsWidth,
				point2.Y - LegsDistance2 - LegsWidth));

			_boxLength = 2 * (halfLength - WallsWidth);
		}

		/// <summary>
		/// Создает отверстия для ящиков
		/// </summary>
		private void CreateBoxHoles()
		{
			const int boxDistance = 30;
			var dresserHeight = _parameters.GetValueParameter(
				ParameterType.DresserHeight);
			var boxNumber = _parameters.GetValueParameter(
				ParameterType.BoxNumber);
			var boxHeight =
				(dresserHeight - boxDistance * (boxNumber + 1)) 
				/ boxNumber;

			var halfWidth = _parameters.GetValueParameter(
				ParameterType.DresserWidth) / 2;
			ksEntity plane = _kompasWrapper.CreatePlaneOffsetXoz(_part, halfWidth);
			ksEntity sketch = _part.NewEntity((int)Obj3dType.o3d_sketch);
			ksSketchDefinition sketchDefinition = sketch.GetDefinition();
			sketchDefinition.SetPlane(plane);
			sketch.Create();

			// Входим в режим редактирования эскиза
			ksDocument2D document2D = sketchDefinition.BeginEdit();

			var point1 = new Point(-_boxLength / 2,
				-dresserHeight + boxDistance);
			var point2 = new Point(_boxLength / 2,
				point1.Y + boxHeight);
			for (int i = 0; i < boxNumber; i++)
			{
				CreateRectangle(point1, point2, document2D);
				point1 = new Point(-_boxLength / 2,
					point2.Y + boxDistance);
				point2 = new Point(_boxLength / 2,
					point1.Y + boxHeight);
			}

			sketchDefinition.EndEdit();

			_kompasWrapper.CutEvolution(_part, sketch,
				_parameters.GetValueParameter(
				ParameterType.BoxWidth));
		}

		/// <summary>
		/// Создать ножки комода
		/// </summary>
		private void CreateLegs()
		{
			ksEntity plane = _part.GetDefaultEntity((int)Obj3dType.o3d_planeXOY);
			ksEntity sketch = _part.NewEntity((int)Obj3dType.o3d_sketch);
			ksSketchDefinition sketchDefinition = sketch.GetDefinition();
			sketchDefinition.SetPlane(plane);
			sketch.Create();

			// Входим в режим редактирования эскиза
			ksDocument2D document2D = sketchDefinition.BeginEdit();

			foreach (var point1 in _legPoints)
			{
				var point2 = new Point(point1.X + LegsWidth,
					point1.Y - LegsWidth);
				CreateRectangle(point1, point2, document2D);
			}

			sketchDefinition.EndEdit();
			_kompasWrapper.BossExtrusion(_part, sketch, -LegsHeight,
				Direction_Type.dtNormal);
		}

		/// <summary>
		/// Создать прямоугольник по двум точкам
		/// </summary>
		/// <param name="point1"></param>
		/// <param name="point2"></param>
		private void CreateRectangle(Point point1,
			Point point2, ksDocument2D document2D)
		{
			var length = Math.Abs(point1.X - point2.X);
			var width = Math.Abs(point1.Y - point2.Y);
			document2D.ksLineSeg(point1.X, point1.Y,
				point1.X + length, point1.Y, 1);
			document2D.ksLineSeg(point1.X + length, point1.Y,
				point1.X + length, point1.Y + width, 1);
			document2D.ksLineSeg(point1.X, point1.Y + width,
				point1.X + length, point1.Y + width, 1);
			document2D.ksLineSeg(point1.X, point1.Y,
				point1.X, point1.Y + width, 1);
		}

		/// <summary>
		/// Создает эллипс
		/// </summary>
		/// <param name="xc">Х координата центра эллипса</param>
		/// <param name="yc">Y координата центра эллипса</param>
		/// <param name="radius1">Первый радиус эллипса</param>
		/// <param name="radius2">Второй радиус эллипса</param>
		/// <returns></returns>
		private ksEllipseParam CreateEllipse(double xc, double yc,
			double radius1, double radius2, ksDocument2D document2D)
		{
			const int ellipseParamId = 22;
			ksEllipseParam ellipseParam = _kompasWrapper.KompasObject.GetParamStruct(ellipseParamId);
			ellipseParam.xc = xc;
			ellipseParam.yc = yc;
			ellipseParam.A = radius1;
			ellipseParam.B = radius2;
			ellipseParam.style = 1;
			document2D.ksEllipse(ellipseParam);
			return ellipseParam;
		}
	}
}