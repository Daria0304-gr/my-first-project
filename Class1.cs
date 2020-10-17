using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{

    public class Inspect

    {
        string Workers = "Иванов И.И.;Зиронов Т.А.; Миронов А.В.; Васильев В.И.;";

        public string GetInspector()
        {
            string nameinstructor = (" Главный инспектор – Васильев Василий Иванович ");
            return (nameinstructor);
        }
        public void GetСarInspection()
        {

            string[] workers = Workers.Split(new char[] { ';' });

            Console.WriteLine("Введите ФИО главного инспектора: ");


            foreach (string namein in workers)
            {
                Console.WriteLine($"Имя нового главы:" + namein);

            }
        }
            public string GenerateNumber(string number, string symbol, string code)
        {
            string answer = string.Empty;
            if (code == "75")
            {
                answer = symbol + number + code;
            }
            else
            {
                answer = "Не удалось";
            }
            return answer;
        }
            public string GetWorker()
        {
            string nameworkers = (" Иванов И.И.;Зиронов Т.А.; Миронов А.В.; Васильев В.И ");
            return (nameworkers);
        }
            public string AddWdorker()
        {

            Console.WriteLine("Введите ФИО нового сотрудника");
            string newworker = Console.ReadLine();
            Workers = String.Concat(Workers + " Новый сотрудник:" + newworker);
            return Workers;
        }
    }
}