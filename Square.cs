using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    public class Square: Geom_Figure
    {
        /// <summary>
        /// Подкласс абстрактного класса Square
        /// Описывает квадрат по цвету, названию, длине стороны, площади, периметру и центру квадрата
        /// </summary>
        private double Side;
        private string ColorSquare;
        private string NameSquare;
        private double X_Squares;
        private double Y_Squares;
        private double Perimetr;
        private double Squares;

        /// <summary>
        /// Конструктор класса Square
        /// Создает объект через имя и длину стороны
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        public Square(double a, string name) : base(name)
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Square
        /// Создает объект без параметров
        /// </summary>
        public Square(): base()
        {
            Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через длину стороны квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        public Square(double a) : base()
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя фигуры, длину стороны квадрата и цвета квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Square(double a, string name, string color) : base(name, color)
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Конструктор класса Circle
        /// Создает объект через имя фигуры, длину стороны квадрата и цвета квадрата
        /// </summary>
        /// <param name="a">Длина стороны квадрата</param>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра квадрата</param>
        /// <param name="y">Одината центра квадрата</param>
        public Square(double a, string name, string color, double x, double y) : base(name, color, x, y)
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
        /// <summary>
        /// Метод возвращает периметр квадрата
        /// </summary>
        /// <returns>Возвращает число типа double - периметр квадрата</returns>
        public override double CountP()
        {
            return (Perimetr = 4*Side);
        }
        /// <summary>
        /// Метод возвращает площадь квадрата
        /// </summary>
        /// <returns>Возвращает число типа double - площадь квадрата</returns>
        public override double CountS()
        {
            return (Squares = Side * Side);
        }
        /// <summary>
        /// Выводит информацию про квадрат
        /// </summary>
        /// <returns>Возвращает строку с именем фигуры, цветом, длину стороны квадрата, координатами центра, площадью и периметром</returns>
        public override string Print()
        {
            return string.Format("Object {0} is squares\nColor: {1}\nSide: {2}\nCenter: ({3}, {4})Squares: {5}\nPerimetr: {6}", NameSquare, ColorSquare, Side, X_Squares, Y_Squares, Squares, Perimetr);
        }
        /// <summary>
        /// Метод возвращает текущий цвет квадрата
        /// </summary>
        /// <returns>Возвращает строку с цветом квадрата</returns>
        public override string GetColor()
        {
            return ColorSquare;
        }
        /// <summary>
        /// Метод возвращает текущее имя квадрата
        /// </summary>
        /// <returns>Возвращает строку с именем квадрата</returns>
        public override string GetName()
        {
            return NameSquare;
        }
        /// <summary>
        /// Метод возвращает текущую абсцису центра квадрата
        /// </summary>
        /// <returns>Возвращает число типа double - абсцису центра квадрата</returns>
        public override double GetX()
        {
            return X_Squares;
        }
        /// <summary>
        /// Метод возвращает текущую ординату центра квадрата
        /// </summary>
        /// <returns>Возвращает число типа double - ординату центра квадрата</returns>
        public override double GetY()
        {
            return Y_Squares;
        }
        /// <summary>
        /// Метод устанавливает имя квадрата и проверяети его корректность
        /// Если строка пуста, то имя = Noname
        /// </summary>
        /// <param name="name">Новое имя квадрата</param>
        public override void SetName(string name)
        {
            if (name == "")
                NameSquare = "Noname";
            else
                NameSquare = name;
        }
        /// <summary>
        /// Метод устанавливает цвет квадрата и проверяети его корректность
        /// Если строка пуста, то цвет = White
        /// </summary>
        /// <param name="color">Новый цвет квадрата</param>
        public override void SetColor(string color)
        {
            if (color == "")
                ColorSquare = "White";
            else
                ColorSquare = color;
        }
        /// <summary>
        /// Метод устанавливает новую абсцису центра квадрата
        /// </summary>
        /// <param name="x">Новая абсциса центра квадрата</param>
        public override void SetX(double x)
        {
            if (x < 0)
                X_Squares = 0;
            else
                X_Squares = x;
        }
        /// <summary>
        /// Метод устанавливает новую ординату центра квадрата
        /// </summary>
        /// <param name="y">Новая ордината центра квадрата</param>
        public override void SetY(double y)
        {
            if (y < 0)
                Y_Squares = 0;
            else
                Y_Squares = y;
        }
        /// <summary>
        /// Метод устанавливает новую сторону квадрата
        /// Если сторона меньше 0, то Side = 0
        /// </summary>
        /// <param name="a">Новая сторона квадрата</param>
        public void SetSide(double a)
        {
            if (a > 0)
                Side = a;
            else
                Side = 0;
        }
    }
}