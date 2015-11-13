//Spencer Kerber
// CIS 199-01
// Project 2 - registration date and time 
// due 10/27/14

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grade_selelection_groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            const string SENIOR_DATE = "November 7, 2014";          // Senior registration date nov 7
            const string JUNIOR_DATE = "November 10, 2014";         // Junior registration date nov 10
            const string SOPHOMORE_DATE_1 = "November 11, 2014";    // Sophomore registration date for names A-D and S-Z nov 11
            const string SOPHOMORE_DATE_2 = "November 12, 2014";    // Sophomore registration date for names E-R nov 12
            const string FRESHMAN_DATE_1 = "November 13, 2014";     // Freshman registration date for names A-D and S-Z nov 13
            const string FRESHMAN_DATE_2 = "November 14, 2014";     // Freshman registration date for names E-R nov 14

            const string FIRST_TIME = " 8:30 A.M.";                 // First registration time 8:30 AM
            const string SECOND_TIME = " 10:00 A.M.";               // Second registration time 10 AM
            const string THIRD_TIME = " 11:30 A.M.";                // Third registration time 11:30 AM
            const string FOURTH_TIME = " 2:00 P.M.";                // Fourth registration time 2 PM
            const string FIFTH_TIME = " 4:00 P.M.";                 // Fifth registration time 4 PM
                      
            char LAST_NAME = char.Parse(last_name_textbox.Text);
            LAST_NAME = char.ToUpper(LAST_NAME); 
        
            if (Senior.Checked)
                if (LAST_NAME >= 'S' && LAST_NAME <= 'Z')
                    MessageBox.Show(SENIOR_DATE + FIRST_TIME);
                else
                {
                    if (LAST_NAME >= 'A' && LAST_NAME <= 'D')
                        MessageBox.Show(SENIOR_DATE + SECOND_TIME);
                    else
                    {
                        if (LAST_NAME >= 'E' && LAST_NAME <= 'I')
                            MessageBox.Show(SENIOR_DATE + THIRD_TIME);
                        else
                        {
                            if (LAST_NAME >= 'J' && LAST_NAME <= 'O')
                                MessageBox.Show(SENIOR_DATE + FOURTH_TIME);
                            else
                                MessageBox.Show(SENIOR_DATE + FIFTH_TIME);
                        }
                    }                   
                }
                if(Junior.Checked)
                    if (LAST_NAME >= 'S' && LAST_NAME <= 'Z')
                        MessageBox.Show(JUNIOR_DATE + FIRST_TIME);
                    else
                    {
                        if (LAST_NAME >= 'A' && LAST_NAME <= 'D')
                            MessageBox.Show(JUNIOR_DATE + SECOND_TIME);
                        else
                        {
                            if (LAST_NAME >= 'E' && LAST_NAME <= 'I')
                                MessageBox.Show(JUNIOR_DATE + THIRD_TIME);
                            else
                            {
                                if (LAST_NAME >= 'J' && LAST_NAME <= 'O')
                                    MessageBox.Show(JUNIOR_DATE + FOURTH_TIME);
                                else                                
                                    MessageBox.Show(JUNIOR_DATE + FIFTH_TIME);                               
                            }
                        }
                    }
                if (Sophomore.Checked)
                    if (LAST_NAME >= 'S' && LAST_NAME <= 'T')
                        MessageBox.Show(SOPHOMORE_DATE_1 + FIRST_TIME);
                    else
                    {
                        if (LAST_NAME >= 'U' && LAST_NAME <= 'V')
                            MessageBox.Show(SOPHOMORE_DATE_1 + SECOND_TIME);
                        else
                        {
                            if (LAST_NAME >= 'W' && LAST_NAME <= 'Z')
                                MessageBox.Show(SOPHOMORE_DATE_1 + THIRD_TIME);
                            else
                            {
                                if (LAST_NAME >= 'A' && LAST_NAME <= 'B')
                                    MessageBox.Show(SOPHOMORE_DATE_1 + FOURTH_TIME);
                                else
                                {
                                    if (LAST_NAME >= 'C' && LAST_NAME <= 'D')
                                        MessageBox.Show(SOPHOMORE_DATE_1 + FIFTH_TIME);
                                    else
                                    {
                                        if (LAST_NAME >= 'E' && LAST_NAME <= 'F')
                                            MessageBox.Show(SOPHOMORE_DATE_2 + FIRST_TIME);
                                        else
                                        {
                                            if (LAST_NAME >= 'G' && LAST_NAME <= 'I')
                                                MessageBox.Show(SOPHOMORE_DATE_2 + SECOND_TIME);
                                            else
                                            {
                                                if (LAST_NAME >= 'J' && LAST_NAME <= 'L')
                                                    MessageBox.Show(SOPHOMORE_DATE_2 + THIRD_TIME);
                                                else
                                                {
                                                    if (LAST_NAME >= 'M' && LAST_NAME <= 'O')
                                                        MessageBox.Show(SOPHOMORE_DATE_2 + FOURTH_TIME);
                                                    else                                                    
                                                        MessageBox.Show(SOPHOMORE_DATE_2 + FIFTH_TIME);                                                    
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
            if( Freshman.Checked)
                if (LAST_NAME >= 'S' && LAST_NAME <= 'T')
                    MessageBox.Show(FRESHMAN_DATE_1 + FIRST_TIME);
                else
                {
                    if (LAST_NAME >= 'U' && LAST_NAME <= 'V')
                        MessageBox.Show(FRESHMAN_DATE_1 + SECOND_TIME);
                    else
                    {
                        if (LAST_NAME >= 'W' && LAST_NAME <= 'Z')
                            MessageBox.Show(FRESHMAN_DATE_1 + THIRD_TIME);
                        else
                        {
                            if (LAST_NAME >= 'A' && LAST_NAME <= 'B')
                                MessageBox.Show(FRESHMAN_DATE_1 + FOURTH_TIME);
                            else
                            {
                                if (LAST_NAME >= 'C' && LAST_NAME <= 'D')
                                    MessageBox.Show(FRESHMAN_DATE_1 + FIFTH_TIME);
                                else
                                {
                                    if (LAST_NAME >= 'E' && LAST_NAME <= 'F')
                                        MessageBox.Show(FRESHMAN_DATE_2 + FIRST_TIME);
                                    else
                                    {
                                        if (LAST_NAME >= 'G' && LAST_NAME <= 'I')
                                            MessageBox.Show(FRESHMAN_DATE_2 + SECOND_TIME);
                                        else
                                        {
                                            if (LAST_NAME >= 'J' && LAST_NAME <= 'L')
                                                MessageBox.Show(FRESHMAN_DATE_2 + THIRD_TIME);
                                            else
                                            {
                                                if (LAST_NAME >= 'M' && LAST_NAME <= 'O')
                                                    MessageBox.Show(FRESHMAN_DATE_2 + FOURTH_TIME);
                                                else                                                
                                                    MessageBox.Show(FRESHMAN_DATE_2 + FIFTH_TIME);                                               
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                                             



                
            
            
            
            
        }
    }
}
