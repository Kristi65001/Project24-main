using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class TStudent
    {
        string surname; //фамилия студента
        string name; //имя студента
        int Course; //номер курса
        string PassedExams;//информация о здаче зачёта
        int Exam1Grade, Exam2Grade, Exam3Grade;//Оценки по предмету
    
        public TStudent(string surname, string name ,int nomerkursa, 
        string PassedExams, int och1,int och2,int och3)
        {
            this.surname = surname;
            this.name = name;
            this.Course = nomerkursa;
            this.PassedExams = PassedExams;
            this.Exam1Grade = och1;
            this.Exam2Grade = och2;
            this.Exam3Grade = och3;
        }
       
        public string Name()
        {
            return name;
        }
        public string Surname()
        {
            return surname;
        }
        
        public string ShowStudent() //метод для вывода информации о студенте
        {
            string s = $"Фамилия: {surname}\n";
            s += $"Имя: {name}\n";
            s += $"Номер курса: {Course}\n";
            s += $"зачёты: {PassedExams}\n";
            s+= $"Оценка за 1 предмет: {Exam1Grade}\n";
            s += $"Оценка за 2 предмет: {Exam2Grade}\n";
            s += $"Оценка за 3 предмет: {Exam3Grade}\n";
            s += "\n";
            return s;
        }
        public bool HasLowGrades()
        {
            // Здесь должна быть реализация метода для проверки оценок.
            return Exam1Grade <= 3 || Exam2Grade <= 3 || Exam3Grade <= 3 || PassedExams=="не сдал";
        }

        // Метод определяет, является ли студент отличником (не имеет оценок 2 или 3).
        // Возвращает true, если студент отличник, и false в противном случае.
        public bool IsHonorStudent()
        {
            // Здесь должна быть реализация метода для проверки статуса отличника.
            return Exam1Grade == 5 && Exam2Grade == 5 && Exam3Grade == 5&& PassedExams=="сдал";
        }
    }

}
