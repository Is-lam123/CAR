using System;

namespace ConsoleApp5
{
    class Client
    {
        //Паспортные данные 
        internal string License { get; set; }

        internal int ID { get; set; }
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string Patronymic { get; set; }
        internal string Number { get; set; }
        internal string DepartmentCode { get; set; }
        internal DateTime DateOfBirth { get; set; }
        internal string Gender { get; set; }
        internal string Seria { get; set; }
        internal string issuedBy { get; set; }
        internal string Address { get; set; }
        internal DateTime DateOfIssue { get; set; }


        internal string GetInfo()
        {
            if (!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Surname) || !string.IsNullOrEmpty(License))
            {
                return $"ID: {ID}, Имя: {Name} Фамилия: {Surname} Лицензия: {License}";
            }
            else
            {
                return "Данных нет";
            }
        }
    }
}