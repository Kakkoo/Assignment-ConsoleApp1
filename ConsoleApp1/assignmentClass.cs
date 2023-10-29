using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AssignmentClass
	{
		double avgFeedback;
		int experience;
		string instructorName;
		string[] instructorSkill;

        //Case sensitive strong comparisons should be done whenever required
        public bool CheckSkill(string technology)//Check Instructor's skill if he/she has it
        {
            for(int i = 0;i < instructorSkill.Length; i++)
            {
                if (instructorSkill[i] == technology)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        public void Instructor()
        {
            
        }

        public void Instructor(string instructorName, double avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }

        public bool validateEligibility() //Instructor with more than 3 years of experience should've an average feedback <= 4.5
                                          //Instructor with less or equal than 3 years of experience should've an average feedback <= 4
        {
            for( int i = 0; i< instructorSkill.Length && instructorSkill[i] != null; i++)
            {
                if(experience > 3 && avgFeedback >= 4.5)
                {
                    return true;
                }else if(experience < 4 && avgFeedback >= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;  
        }

    }
}
