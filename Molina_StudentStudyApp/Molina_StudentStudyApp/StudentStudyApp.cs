using System;

namespace Molina_StudentStudyApp
{
    class StudentStudyApp
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            Student stu = new Student();
            StudentUI ui = new StudentUI();

            info.AssignementInfo();

            stu.Name = ui.GetName();
            stu.ID = ui.GetStudentID();

            ui.FillHours(stu);

            ui.DisplayData(stu);
            
        }
    }
}
