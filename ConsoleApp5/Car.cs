namespace ConsoleApp5
{
    class Car
    {
        internal int ID { get; set; }
        internal string Brand { get; set; }
        internal string YearIssue { get; set; }
        internal string Mileage { get; set; }
        internal bool Status { get; set; }
        internal double Price { get; set; }

        internal Car(int id, string brand, string yearissue, string mileage, bool status, double price)
        {
            ID = id;
            Brand = brand;
            YearIssue = yearissue;
            Mileage = mileage;
            Status = status;
            Price = price;
        }

        internal string GetInfo()
        {
            return $"ID: {ID}, Марка: {Brand}, Дата выпуска: {YearIssue}, Пробег: {Mileage}, Статус: {Status} Цена: {Price} рублей";
        }
    }
}