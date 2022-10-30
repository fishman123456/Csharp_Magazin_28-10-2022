// See https://aka.ms/new-console-template for more information
// Разработать Магазин с конструктором и полями
// название
// адрес
// площадь Используя механизм свойств для полей класса (get, set)
// Необходимо реализовать следующие перегрузки.
// + для увеличения магазина на указанную величину
// - для уменьшения магазина на указанную величину
// ==  роверка на равенство площадей магазинов
// < > проверка на больше или меньше площади магазина
// != и Equals

using System.Diagnostics;

shop f = new shop("Рыбный","Бардина-4",8);

Console.WriteLine(f + 4);
shop one = new shop("первый", "рыбный", 2);
Console.WriteLine(one);
shop two = new shop("Молочный", "Комсомольская площадка", 2);
Console.WriteLine(two);
if (one == one)
{
    Console.WriteLine("==");
}
else Console.WriteLine("=!");
f.print(two);

class shop
{
    string _name;
    string _description;
    int _square;

    public shop (string name, string descriptions, int square)
    {
        _name = name;// имя магазина
        _description = descriptions;// пояснение, адрес
        _square = square;// площадь метров квадратных
    }
    public override string ToString()
    {
        return $"Магазин \"{this._name}\" по адресу {this._description}, площадью {this._square} м^2.";
    }
    public string? Name
    {
        get { return this._name; }// принимает значение
        set { this._name = value; } // берет значение
    }
    public string? Description
    {
        get { return this._description; }// - // - // - //
        set { this._description = value; }// - // - // - //
    }
    public int? Square
    { 
        get { return this._square; } // - // - // - // - //
        set { this._square = (int)(value == 0 ? 1 : value); } // - // - // - //
}
    public static shop operator +(shop v1,int d)
    {
        v1._square += d;
        return v1;
       
    }

    public static bool operator ==(shop left, shop right)
    {
        if (left._square == right._square)
        {
            Console.WriteLine("Площади равны");
                return true;
        }
        Console.WriteLine("Площади не совпадают");
        return false;
    }

    public static bool operator !=(shop? left, shop? right)
    {
        return !(left == right);
    }
    public void print(shop shop)
    {
        Console.WriteLine(shop);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}