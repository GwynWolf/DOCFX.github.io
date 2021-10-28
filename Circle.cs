using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    public class Circle: Geom_Figure
    {
        /// <summary>
        /// Подкласс абстрактного класса Geom_Figure
        /// Описывает круг по цвету, названию, радиусу, площади, периметру и центру окружности
        /// </summary>
        private double Radius;
        private string ColorCirc;
        private string NameCirc;
        private double X_Circle;
        private double Y_Circle;
        private double Perimetr;
        private double Square;
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя и радиус окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        public Circle(double R, string name): base(name)
        {
            Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект без параметров
        /// </summary>
        public Circle() : base()
        {
            Radius = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через радиус окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        public Circle(double R): base()
        {
            Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя, радиус окружности и цвет окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Circle(double R, string name, string color): base(name, color)
        {
            Radius = R;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через радиус окружности, имя, цвет фигуры и цетра его окружности
        /// </summary>
        /// <param name="R">Радиус окружности</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра фигуры</param>
        /// <param name="y">Ордината центра фигуры</param>
        public Circle(double R, string name, string color, double x, double y) : base(name, color, x, y)
        {
            Radius = R;
        }
        /// <summary>
        /// Метод возвращает периметр окружности
        /// </summary>
        /// <returns>Возвращает число типа double - периметр окружности по известному радиусу</returns>
        public override double CountP()
        {
            return  (Perimetr = 2*Radius*Math.PI);
        }
        /// <summary>
        /// Метод возвращает площадь окружности
        /// </summary>
        /// <returns>Возвращает число типа double - площадь круга по известному радиусу</returns>
        public override double CountS()
        {
            return (Square = Radius * Radius * Math.PI);
        }
        /// <summary>
        /// Выводит информацию об окружности
        /// </summary>
        /// <returns>Возвращает строку с именем фигуры, цветом, радиусом, координатами центра, площадью и периметром</returns>
        public override string Print()
        {
            return string.Format("Object {0} is circle\nColor: {1}\nRadius: {2}\nCenter: ({3}, {4})Squares: {5}\nPerimetr: {6}", NameCirc, ColorCirc, Radius, X_Circle, Y_Circle, Square, Perimetr);
        }
        /// <summary>
        /// Метод возвращает текущий цвет окружности
        /// </summary>
        /// <returns>Возвращает строку с цветом фигокружностиуры</returns>
        public override string GetColor()
        {
            return ColorCirc;
        }
        /// <summary>
        /// Метод возвращает текущее имя окружности
        /// </summary>
        /// <returns>Возвращает строку с именем окружности</returns>
        public override string GetName()
        { 
            return NameCirc;
        }
        /// <summary>
        /// Метод возвращает текущую абсцису центра окружности
        /// </summary>
        /// <returns>Возвращает число типа double - абсцису центра окружности</returns>
        public override double GetX()
        {
            return X_Circle;
        }
        /// <summary>
        /// Метод возвращает текущую ординату центра окружности
        /// </summary>
        /// <returns>Возвращает число типа double - ординату центра окружности</returns>
        public override double GetY()
        {
            return Y_Circle;
        }
        /// <summary>
        /// Метод устанавливает имя окружности и проверяети его корректность
        /// Если строка пуста, то имя = Noname
        /// </summary>
        /// <param name="name">Новое имя окружности</param>
        public override void SetName(string name)
        {
            if (name == "")
                NameCirc = "Noname";
            else
                NameCirc = name;
        }
        /// <summary>
        /// Метод устанавливает цвет окружности и проверяети его корректность
        /// Если строка пуста, то цвет = White
        /// </summary>
        /// <param name="color">Новый цвет окружности</param>
        public override void SetColor(string color)
        {
            if (color == "")
                ColorCirc = "White";
            else
                ColorCirc = color;
        }
        /// <summary>
        /// Метод устанавливает новую абсцису центра окружности
        /// </summary>
        /// <param name="x">Новая абсциса центра окружности</param>
        public override void SetX(double x)
        {
             X_Circle = x;
        }
        /// <summary>
        /// Метод устанавливает новую ординату центра окружности
        /// </summary>
        /// <param name="y">Новая ордината центра окружности</param>
        public override void SetY(double y)
        {
            Y_Circle = y;
        }
        /// <summary>
        /// Метод устанавливает новый радиус окружности
        /// Если новый радиус меньше нуля, то новый радиус = 0
        /// </summary>
        /// <param name="R">Новый радиус окружности</param>
        public void SetRadius(double R)
        {
            if (R > 0)
                Radius = R;
            else
                Radius = 0;
        }
    }
}