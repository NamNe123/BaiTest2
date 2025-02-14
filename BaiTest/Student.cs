using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTest
{
    public class Score
    {
        public float Math { get; set; }
        public float Physic { get; set; }
        public float Chemistry { get; set; }

        public Score(float math, float physic, float chemistry)
        {
            Math = math;
            Physic = physic;
            Chemistry = chemistry;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public Score Score { get; set; }

        public Student(string name, float math, float physic, float chemistry)
        {
            Name = name;
            Score = new Score(math, physic, chemistry);
        }

        public double GetAverageScore()
        {
            return (Score.Math + Score.Physic + Score.Chemistry) / 3.0;
        }
    }

}
