using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Vodka
    {
        public int price;
        public int endurance;
        public string producing_country;
        public string Vodka_class;
        public string name;
        public void GetInfo()
        {
            Console.WriteLine($"Название: {name}\t Цена: {price}\t Выдержка: {endurance}\t Страна производителя: {producing_country}\t Класс водки: {Vodka_class} ");
        }
    }
    static void Main(string[] args)
    {
        Vodka Finlandia = new Vodka();
        Finlandia.name = "Finlandia";
        Finlandia.price = 359;
        Finlandia.endurance = 40;
        Finlandia.producing_country = "Финляндия";
        Finlandia.Vodka_class = "Премиум";
        Finlandia.GetInfo();

        Vodka Grey_Goose = new Vodka();
        Grey_Goose.name = "Grey_Goose";
        Grey_Goose.price = 689;
        Grey_Goose.endurance = 40;
        Grey_Goose.producing_country = "Франция";
        Grey_Goose.Vodka_class = "Премиум";
        Grey_Goose.GetInfo();

        Vodka Nemiroff = new Vodka();
        Nemiroff.name = "Nemiroff";
        Nemiroff.price = 126;
        Nemiroff.endurance = 40;
        Nemiroff.producing_country = "Украина";
        Nemiroff.Vodka_class = "Стандарт";
        Nemiroff.GetInfo();

        Vodka Zubrowka = new Vodka();
        Zubrowka.name = "Zubrowka";
        Zubrowka.price = 125;
        Zubrowka.endurance = 38;
        Zubrowka.producing_country = "Польша";
        Zubrowka.Vodka_class = "Премиум";
        Zubrowka.GetInfo();

        Vodka Cossack_Council = new Vodka();
        Cossack_Council.name = "Козацька Рада";
        Cossack_Council.price = 180;
        Cossack_Council.endurance = 40;
        Cossack_Council.producing_country = "Украина";
        Cossack_Council.Vodka_class = "Стандарт";
        Cossack_Council.GetInfo();

        var v = new[] {
            Finlandia,
            Grey_Goose,
            Nemiroff,
            Zubrowka,
            Cossack_Council
        };
        Console.WriteLine("Выберите: ");
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine("Вы выбрали: ");
        v[n].GetInfo();

        Console.ReadKey();
    }
}