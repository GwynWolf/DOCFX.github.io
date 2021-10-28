using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public abstract class Geom_Figure
    {
        /// <summary>
        /// Абстрактный базовый класс Geom_Figure
        /// Включает в себя базовые функции описания для круга и квадрата
        /// </summary>
        private double Perimetr;
        private double Squares;
        private string Color;
        private string Name;
        private double X;
        private double Y;
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект без параметров
        /// </summary>
        public Geom_Figure()
        {
            Name = "Noname";
            Color = "White";
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        public Geom_Figure(string name)
        {
            Name = name;
            Color = "White";
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры и цветом
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        public Geom_Figure(string name, string color)
        {
            Name = name;
            Color = color;
            X = 0;
            Y = 0;
        }
        /// <summary>
        /// Конструктор класса Geom_Figure
        /// Создает объект с именем фигуры, цветом и координатами центра
        /// </summary>
        /// <param name="name">Имя фигуры</param>
        /// <param name="color">Цвет фигуры</param>
        /// <param name="x">Абсциса центра фигуры</param>
        /// <param name="y">Ордината центра фигуры</param>
        public Geom_Figure(string name, string color, double x, double y)
        {
            Name = name;
            Color = color;
            X = x;
            Y = y;
        }
        /// <summary>
        /// Метод возвращает текущее имя фигуры
        /// </summary>
        /// <returns>Возвращает строку с именем фигуры</returns>
        public abstract string GetName();
        /// <summary>
        /// Метод возвращает текущий цвет фигуры
        /// </summary>
        /// <returns>Возвращает строку с цветом фигуры</returns>
        public abstract string GetColor();
        /// <summary>
        /// Метод возвращает текущую абсцису центра фигуры
        /// </summary>
        /// <returns>Возвращает число типа double - абсцису центра фигуры</returns>
        public abstract double GetX();
        /// <summary>
        /// Метод возвращает текущую ординату центра фигуры
        /// </summary>
        /// <returns>Возвращает число типа double - ординату центра фигуры</returns>
        public abstract double GetY();
        /// <summary>
        /// Метод возвращает периметр фигуры
        /// </summary>
        /// <returns>Возвращает число типа double - периметр фигуры</returns>
        public abstract double CountP();
        /// <summary>
        /// Метод возвращает площадь фигуры
        /// </summary>
        /// <returns>Возвращает число типа double - площадь фигуры</returns>
        public abstract double CountS();
        /// <summary>
        /// Выводит информацию об фигуры
        /// </summary>
        /// <returns>Возвращает строку с параметрами фигуры</returns>
        public abstract string Print();
        /// <summary>
        /// Метод устанавливает имя фигуры и проверяети его корректность
        /// Если строка пуста, то имя = Noname
        /// </summary>
        /// <param name="name">Новое имя фигуры</param>
        public abstract void SetName(string name);
        /// <summary>
        /// Метод устанавливает цвет фигуры и проверяети его корректность
        /// Если строка пуста, то цвет = White
        /// </summary>
        /// <param name="color">Новый цвет фигуры</param>
        public abstract void SetColor(string color);
        /// <summary>
        /// Метод устанавливает новую абсцису центра окружности
        /// </summary>
        /// <param name="x">Новая абсциса фигуры</param>
        public abstract void SetX(double x);
        /// <summary>
        /// Метод устанавливает новую ординату центра окружности
        /// </summary>
        /// <param name="y">Новая ордината окружности</param>
        public abstract void SetY(double y);
    }
}
