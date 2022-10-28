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
    public int Get_sqare(int sqare)
    {
        int _sqare = sqare;
        return _sqare;
    }
}