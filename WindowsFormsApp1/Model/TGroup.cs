using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class TGroup
    {
        private string nameGroup; //имя группы
        private int numStudents; //количество студентов в группе
        private TStudent[] students; //студенты группы
        private string mount; //название месяца
    
        public TGroup()
        {
            try //обработка исключения
            {
                string path = "D:\\list.txt"; //сохраняем путь доступа к файлу
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Файл не найден.");
                }
                // Создаем объект класса StreamReader для считывания данных с файла.
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    // Объявляем локальные переменные для временного хранения данных.
                    // int day, month, year; string town.
                    string surname; string name; int Course, Exam1Grade,Exam2Grade,Exam3Grade;
                    string PassedExams;
                    nameGroup = sr.ReadLine();//считываем с файла название группы
                    mount= sr.ReadLine();////считываем с файла название месяца
                    numStudents = int.Parse(sr.ReadLine()); //считываем с файла количество студентов группы
                    sr.ReadLine(); //перемещаем указатель в файле на строчку вниз
                    students = new TStudent[numStudents]; //создаем массив объектов
                    for (int i = 0; i < numStudents; i++) //создаем студентов
                    {
                        //Считываем данные с файла.
                        surname = sr.ReadLine();
                        name = sr.ReadLine();
                        Course = int.Parse(sr.ReadLine());
                        PassedExams =sr.ReadLine();
                        Exam1Grade = int.Parse(sr.ReadLine());
                        Exam2Grade = int.Parse(sr.ReadLine());
                        Exam3Grade = int.Parse(sr.ReadLine());
                        //town = sr.ReadLine();
                        //DateTime date = new DateTime(year, month, day);
                        //Создаем студента.
                        students[i] = new TStudent(surname, name,Course,PassedExams, Exam1Grade, Exam2Grade,Exam3Grade);
                        sr.ReadLine(); // читаем пустую строку между студентами
                    }
                }
            }
            catch (Exception e) //В случае исключения, выводим информацию об ошибке
            {
                Console.WriteLine(e.Message);
            }
        }

        public string ShowGroup() //Метод для отображения студентов в группе
        {
            // Начинаем формировать строку с заголовка, включающего название группы и месяц
            string s = $"Список студентов группы: {nameGroup} (Ведомость за месяц:{mount})\n";
            s += "\n"; // Добавляем пустую строку для разделения заголовка и списка студентов
            // Проверяем, есть ли студенты в группе
            if (students == null || students.Length == 0)
            {
                // Возвращаем сообщение, если в группе нет студентов
                return "Нет студентов в группе."; 
            }
            // Проходим по массиву студентов и добавляем информацию о каждом студенте в строку
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null) // Проверяем, инициализирован ли студент
                {
                    s += students[i].ShowStudent(); // Добавляем информацию о студенте
                }
                else
                {
                    // Добавляем сообщение для неинициализированного студента
                    s += "Студент не инициализирован.\n"; 
                }
            }
            // Добавляем информацию о получающих стипендию и неуспевающих студентах
            s += ShowPol();
            // Возвращаем сформированную строку
            return s;
        }

        public string ShowPol()
        {
            // Инициализация строки для хранения информации о стипендиях
            string text = "Получающие степендию:\n";
            text+= "Отличники группы:\n";

            // Проход по массиву студентов для нахождения отличников
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null) // Проверка, что студент не null
                {
                    if (students[i].IsHonorStudent()) // Проверка, что студент является отличником
                    {
                        // Добавление имени и фамилии отличника в строку
                        text =text+ $" {students[i].Surname()} {students[i].Name()}\n";
                    }
                }
            }
            // Добавление раздела для неуспевающих студентов
            text += "Неуспевающие:\n";
            // Проход по массиву студентов для нахождения неуспевающих
            for (int i = 0; i < students.Length; i++)
            {
                // Проверка, что студент не null
                if (students[i] != null)
                {
                    if (students[i].HasLowGrades()) // Проверка, что студент имеет низкие оценки
                    {
                        // Добавление имени и фамилии неуспевающего студента в строку
                        text = text+ $" {students[i].Surname()} {students[i].Name()}";
                    }
                }
            }
            // Возврат сформированной строки
            return text;
        }
    }
}
