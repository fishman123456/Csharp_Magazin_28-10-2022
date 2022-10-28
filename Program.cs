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

shop f = new shop("dfgsd","dfs",8);

Console.WriteLine(f + 4);

class shop
{
    string _name;
    string _description;
    int _sqare;

    public shop (string name, string descriptions, int sqare)
    {
        _name = name;
        _description = descriptions;
        _sqare = sqare;
    }


    public static shop operator +(shop v1,int d)
    {
        v1._sqare += d;
        return v1;
       
    }

    public static bool operator ==(shop? left, shop? right)
    {
        return EqualityComparer<shop>.Default.Equals(left, right);
    }

    public static bool operator !=(shop? left, shop? right)
    {
        return !(left == right);
    }
}