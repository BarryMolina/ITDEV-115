using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Molina_StudentList
{
    class StudentS
    {


        List<Student> theStudentList;



        public string PopulateStudents(string path)
        {
            theStudentList = new List<Student>();
            string line;
            string[] info;
            Student student;
            string msg = "";

            try
            {
                StreamReader reader = new StreamReader(path);
                while (!String.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    info = line.Split(',');
                    student = new Student(info[0], info[1], info[2]);
                    for (int i = 3; i < info.Length; i += 2)
                    {
                        student.EnterGrade(Int32.Parse(info[i]), Int32.Parse(info[i + 1]));
                        student.CalGrade();
                    }
                    theStudentList.Add(student);
                }
                reader.Close();
            }
            catch (IOException ex)
            {
                msg = "Unable to read file";
            }
            catch (FormatException ex)
            {
                msg = "File not in correct format";
            }
            catch (Exception ex)
            {
                msg = "Something went wrong" + ex.Message;
            }

            return msg;
        }

        public int ListLength
        {
            get { return theStudentList.Count; }
        }

        public string StudentID(int index)
        {
            return theStudentList.ElementAt(index).ID;
        }

        public string StudentLastName(int index)
        {
            return theStudentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {

            return theStudentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {

            return theStudentList.ElementAt(index).Average;
        }

    }

}

